using AutoMapper;
using Product.Command.Application.Commands;
using Product.Command.Application.Dto;

namespace Product.Command.Application.MappingProfiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateProductRequest, CreateProductCommand>();
    }
}
