using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;
using YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces;
using YinuoYang.Core.HotelManagementSystem.ServiceInterfaces;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IServiceRepository _serviceRepository;
        public CustomerService(ICustomerRepository customerRepository, IServiceRepository serviceRepository)
        {
            _customerRepository = customerRepository;
            _serviceRepository = serviceRepository;
        }

        public async Task AddCustomerAsync(CustomerRequestModel customerRequest)
        {
            var customer = new Customer
            {
                Id = customerRequest.Id,
                Address = customerRequest.Address,
                Advance = customerRequest.Advance,
                BookingDays = customerRequest.BookingDays,
                CheckIn = customerRequest.CheckIn,
                CName = customerRequest.CName,
                Email = customerRequest.Email,
                RoomNo = customerRequest.RoomNo,
                Phone = customerRequest.Phone,
                TotalPersons = customerRequest.TotalPersons

            };
            await _customerRepository.AddAsync(customer);

        }

        public async Task UpdateCustomerAsync(CustomerRequestModel customerRequest)
        {
            var customer = new Customer
            {
                Id = customerRequest.Id,
                Address = customerRequest.Address,
                Advance = customerRequest.Advance,
                BookingDays = customerRequest.BookingDays,
                CheckIn = customerRequest.CheckIn,
                CName = customerRequest.CName,
                Email = customerRequest.Email,
                RoomNo = customerRequest.RoomNo,
                Phone = customerRequest.Phone,
                TotalPersons = customerRequest.TotalPersons

            };
            await _customerRepository.UpdateAsync(customer);

        }

        public async Task DeleteCustomerAsync(int customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            await _customerRepository.DeleteAsync(customer);


        }

        public async Task<IEnumerable<CustomerResponseModel>> GetAllCustomersAsync()
        {
            var customers = await _customerRepository.ListAllAsync();
            var response = new List<CustomerResponseModel>();
            foreach (var customer in customers)
            {
                response.Add(new CustomerResponseModel
                {
                    Id = customer.Id,
                    BookingDays = customer.BookingDays,
                    CheckIn = customer.CheckIn,
                    CName = customer.CName,
                    Phone = customer.Phone

                    
                });
            }

            return response;
        }

        public async Task<CustomerDetailResponseModel> GetCustomerDetailAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            var response = new CustomerDetailResponseModel();
            response.CheckIn = customer.CheckIn;
            response.Address = customer.Address;
            response.Advance = customer.Advance;
            response.BookingDays = customer.BookingDays;
            response.CName = customer.CName;
            response.Email = customer.Email;
            response.Id = customer.Id;
            //response.Room = customer.Room;
            response.RoomNo = customer.RoomNo;
            response.Phone = customer.Phone;
            response.TotalPersons = customer.TotalPersons;
            response.Room = new RoomResponseModel
            {
                Id = customer.Room.Id,
                RTCode = customer.Room.RTCode,
                Status = customer.Room.Status,
                RoomType = new RoomTypeResponseModel
                {
                    Id = customer.Room.Roomtype.Id,
                    Rent = customer.Room.Roomtype.Rent,
                    Rtdesc = customer.Room.Roomtype.Rtdesc
                }
            };
            var services = await _serviceRepository.GetServicesByCustomer(customer.Room.Id);
            response.Services = new List<Service>();
            foreach (var service in services)
            {
                response.Services.Add(new Service
                {
                    amount = service.amount,
                    Id = service.Id,
                    RoomNo = service.RoomNo,
                    Sdesc = service.Sdesc,
                    ServiceDate = service.ServiceDate
                });
            }
            //response.Services = customer.Room.Services;
            return response;
        }

        public Task<RoomResponseModel> GetRoomForCustomerAsync(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ServiceResponseModel>> GetServicesForCustomerAsync(int customerId)
        {
            throw new System.NotImplementedException();
        }


    }
}