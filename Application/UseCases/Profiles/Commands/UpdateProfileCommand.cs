using Application.Common.Interfaces.Repository;
using Application.Common.Models;
using Domain.Entities;
using MediatR;
using System.Text.Json.Serialization;

namespace Application.UseCases.AudienceCase.Commands
{
    public class UpdateProfileCommand : IRequest<ResponseModel>
    {
        public string ProfileId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

    }
    public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, ResponseModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateProfileCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ResponseModel> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
        {

            var profile = _unitOfWork.ProfileStore.GetByID(request.ProfileId);
            if (profile == null) return ResponseModel.Failure("Profile not found");

            profile.LastName = request.LastName;
            profile.FirstName = request.FirstName;

            _unitOfWork.ProfileStore.Update(profile);
            _unitOfWork.Commit();
            return ResponseModel.Success("Profile.Update");
        }
    }
}
