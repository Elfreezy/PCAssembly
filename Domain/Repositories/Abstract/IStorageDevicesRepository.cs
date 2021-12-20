using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IStorageDevicesRepository
    {
        IQueryable<StorageDevice> GetStorageDevices();
        StorageDevice GetStorageDeviceById(Guid id);
        void SaveStorageDevice(StorageDevice entity);
        void DeleteStorageDevice(Guid id);

        IQueryable<StorageDevice> GetStorageDevicesBySocket(Guid id);
    }
}
