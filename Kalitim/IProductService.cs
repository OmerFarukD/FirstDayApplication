using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kalitim;

// İNTERFACE BİR SOYUT CLASSTIR.
// İNTERFACE LER NEW lenemez.
// İNTERFACELER BİRER ANLAŞMADIR.
public interface IProductService
{
    void Add();
    void Remove();
    void GetList();
}
