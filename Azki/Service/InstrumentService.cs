﻿using azki.Dto;
using Azki.Enum;
using azki.Model;
using azki.Repositories;
using Azki.Dto;

namespace azki.Service
{
    public class InstrumentService : IInstrumentService
    {
        private readonly IInstrumentRepository _repository;
        private const int OptionCounts = 4;

        public InstrumentService(IInstrumentRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<GetRandomResponseDto>> GetRandom()
        {
            var instruments = await _repository.GetAll();
            var randomNumber = new Random();
            var numbers = new List<int>();
            while (numbers.Count < OptionCounts)
            {
                var number = randomNumber.Next(0, (instruments.Count - 1));
                if (numbers.Contains(number) == false) numbers.Add(number);
            }
            var result = instruments.Where((x, i) => numbers.Contains(i)).ToList();
            return result.Select(GetRandomResponseDto.MapFromModel);
        }

        public async Task<GetResultResponseDto> GetResult(GetResultRequestDto dto)
        {
            var instrument = await _repository.Get(dto.InstrumentId);

            var discount = await GetDiscount(instrument.InsuranceType);

            return GetResultResponseDto.MapFromModel(instrument,
                instrument.InstrumentColors.First(i => i.Id == dto.InstrumentColorId), discount);
        }

        public async Task<List<InstrumentColor>> GetInstrumentColors(long instrumentId)
        {
            var instrument = await _repository.Get(instrumentId);

            return instrument.InstrumentColors.ToList();
        }

        private async Task<Discount> GetDiscount(InsuranceTypeEnum type)
        {
            var discount = await _repository.GetDiscount(type);
            if(discount == null) return new Discount();


            discount.IsActive = false;

            await _repository.UpdateDiscount(discount);

            return discount;

        }
    }

}