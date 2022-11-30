using Application.Common.Constant;
using Application.Common.Interfaces.Repository;
using Application.Common.Models;
using Application.Common.Models.ProfileDTO;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Text.Json.Serialization;

namespace Application.UseCases.AudienceCase.Commands
{
    public class CreateProfileCommand : IRequest<ResponseModel<CreateProfileResponseModel>>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string Email { get; set; }
    }
    public class CreateProfileCommandHandler : IRequestHandler<CreateProfileCommand, ResponseModel<CreateProfileResponseModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
    private IMapper mapper; 


        public CreateProfileCommandHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ResponseModel<CreateProfileResponseModel>> Handle(CreateProfileCommand request, CancellationToken cancellationToken)
        {
            var profile = this.mapper.Map<CreateProfileCommand, CustomerProfile>(request);
            _unitOfWork.ProfileStore.Insert(profile);
            _unitOfWork.Commit();
            var response = new CreateProfileResponseModel { IsSuccessful = true, Message = "Profile created successfully" };
            return ResponseModel< CreateProfileResponseModel>.Success(data:response, "Profile.Create");
        }
    }
}
