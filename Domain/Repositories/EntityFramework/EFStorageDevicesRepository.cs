using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFStorageDevicesRepository : IStorageDevicesRepository
    {
        private readonly AppDbContext context;
        public EFStorageDevicesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<StorageDevice> GetStorageDevices()
        {
            return context.StorageDevices;
        }

        public StorageDevice GetStorageDeviceById(Guid id)
        {
            return context.StorageDevices.FirstOrDefault(x => x.Id == id);
        }

        public void SaveStorageDevice(StorageDevice entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void DeleteStorageDevice(Guid id)
        {
            context.StorageDevices.Remove(new StorageDevice() { Id = id });
            context.SaveChanges();
        }

        // -------------------------------

        public IQueryable<StorageDevice> GetStorageDevicesBySocket(Guid id)
        {
            var formFactorStorageDevice = "";
            if (context.Motherboards.FirstOrDefault(x => x.Id == id) != null)
            {
                formFactorStorageDevice = context.Motherboards.FirstOrDefault(x => x.Id == id).FormFactorStorageDevice;
            }
            return context.StorageDevices.Where(x => x.FormFactor == formFactorStorageDevice);
        }
    }
}
