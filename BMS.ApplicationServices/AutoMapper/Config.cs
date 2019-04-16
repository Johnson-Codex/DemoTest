using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BMS.ApplicationServices.Model.View;
using BMS.Core.Model;

namespace BMS.ApplicationServices.AutoMapper
{
    public class Config 
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {
                //TODO: Add AutoMapper config for Test (Entity) to TestViewModel
                config.CreateMap<Test, TestViewModel>()
                    .ForMember(dest => dest.TestName, opts => opts.MapFrom(src => src.Name));


                //TODO: Add AutoMapper config for Test (Entity) to TestInputModel
            });
        }
    }
}
