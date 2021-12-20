using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain
{
    // Контроллер для управления классами интерфейсами реализующими взаимодействие с БД
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public IComponentsRepository Components { get; set; }
        public IProcessorsRepository Processors { get; set; }
        public IMotherboardsRepository Motherboards { get; set; }
        public IVideoadaptersRepository Videoadapters { get; set; }
        public IStorageDevicesRepository StorageDevices { get; set; }
        public ISoundCardsRepository SoundCards { get; set; }
        public IPowerUnitsRepository PowerUnits { get; set; }



        public DataManager( ITextFieldsRepository textFieldsRepository,
                            IServiceItemsRepository serviceItemsRepository,
                            IComponentsRepository componentsRepository,
                            IProcessorsRepository processorsRepository,
                            IMotherboardsRepository motherboardsRepository,
                            IVideoadaptersRepository videoadaptersRepository,
                            IStorageDevicesRepository storageDevicesRepository,
                            ISoundCardsRepository soundCardsRepository,
                            IPowerUnitsRepository powerUnitsRepository
        )
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            Processors = processorsRepository;
            Motherboards = motherboardsRepository;
            Components = componentsRepository;
            Videoadapters = videoadaptersRepository;
            StorageDevices = storageDevicesRepository;
            SoundCards = soundCardsRepository;
            PowerUnits = powerUnitsRepository;
        }
    }
}
