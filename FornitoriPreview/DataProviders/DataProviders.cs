using Drk.Core.Data;
using Drk.Core.Interfaces;
using Drk.DAL;
using FornitoriApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.DataProviders
{
    public class FornitoriDataProvider : DataProviderBase<FornitoreDto, Fornitori>, IDataProvider<FornitoreDto>
    {
       IRepository<Fornitori> _fornitori;
       
        public FornitoriDataProvider(IEntityManager entityManager) 
        {
            em = entityManager;
            _fornitori = em.GetRepository<Fornitori>();
           
        }
        public void Add(FornitoreDto dto)
        {
            var entity = ToEntity(dto);
            _fornitori.Save(entity);
        }

        public ObservableCollection<FornitoreDto> All()
        {
            ObservableCollection<FornitoreDto> data = new ObservableCollection<FornitoreDto>();
            _fornitori.All().ForEach(x =>
            {
                var dto = ToDto(x);
                
                data.Add(dto);
            });
            return data;
        }

        public void Delete(int id)
        {
             
        }
        private void Delete(FornitoreDto entity)
        { 
            
        }
        public FornitoreDto Get(int id)
        {
            var entity = _fornitori.Find(id);
            var dto = ToDto(entity);
            return dto;
        }

        public ObservableCollection<FornitoreDto> GetBy(Func<FornitoreDto, bool> predicate)
        {
            ObservableCollection<FornitoreDto> result = new ObservableCollection<FornitoreDto>();
            //var data = _dataTable.Where(predicate);
            //foreach (var entity in data)
            //{
            //    result.Add(entity);
            //}
            return result;
        }

        protected override FornitoreDto ToDto(Fornitori entity)
        {
            
            var dto = new FornitoreDto(entity.FornitoreID)
            {
                RagioneSociale = entity.RagioneSociale,
                NomeInterno = entity.NomeInternoFornitore,
                IsActive = entity.FlagAttivo,
                Responsabile = new PersonaDto() 
                { 
                    Description = entity.Responsabile 
                },
                SedeLegale = new AddressDto() 
                { 
                    Indirizzo = entity.Indirizzo,
                    CAP =entity.Destinazioni.Cap,
                    Provincia = entity.Destinazioni.Provincia,
                    City = entity.Destinazioni.Nome
                    
                }
            };
            entity.UsiImmagine.ToList().ForEach(x => 
            {
                var immagine = new ImmagineDto(x.ImmagineID)
                {
                    Nome = x.Immagini.NomeFile 
                };
                dto.Immagini.Add(immagine);
            });

            return dto;
        }

        protected override Fornitori ToEntity(FornitoreDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
