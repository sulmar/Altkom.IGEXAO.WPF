using Altkom.IGEXAO.MicroCAD.Models;
using System;

namespace Altkom.IGEXAO.MicroCAD.IServices
{
    public interface ISchemasService
    {
        Schema Get(int id);

        void Add(Schema schema);
    }
}
