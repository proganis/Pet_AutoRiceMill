﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AutoRiceMill.Parties.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoRiceMill.Parties
{
    public interface IPartyAppService: IApplicationService
    {
        Task<ListResultDto<PartyDto>> GetAll(GetAllPartiesInput input);
        Task Create(CreatePartyInput input);
        Task UpdateParty(UpdatePartyInput input);
        Task<PartyDto> Get(EntityDto input);
        Task Delete(EntityDto input);
    }
}
