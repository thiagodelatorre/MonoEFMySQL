using System.Data.Entity.Migrations.Infrastructure;

namespace EF
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Age : DbMigration, IMigrationMetadata
    {
        	string IMigrationMetadata.Id {
			get { return "201511200243284_Age"; }
		}

		string IMigrationMetadata.Source {
			get { return null; }
		}


		string IMigrationMetadata.Target {
			get { return "H4sIAAAAAAAAA81Xy27bOhDdX6D/QHCdik6CXtwGUovUiYvgxokRpd3T0tghSpGqSAX2t3XRT+ovdKi3Jb8aFEXhjUTNnDk8nAf949t3//0qkeQZMiO0CuipN6IEVKRjoZYBze3i9X/0/btX//jXcbIin2u7c2eHnsoE9Mna9IIxEz1Bwo2XiCjTRi+sF+mE8Vizs9HoLTs9ZYAQFLEI8R9yZUUCxQu+jrWKILU5l1MdgzTVOn4JC1RyxxMwKY8goNcTSi6l4Bg5BLmghCulLbfI6+KTgdBmWi3DFBe4fFyngHYLLg1UfC9a82Opj84cddY61lBRbqxOfhHw9LzSgvXdX6QobbRCta5RVbt2uy4UC+gMD8wB90NdjGXmzJycXml0Qq4nJ80Jj7zid0LGubR5BoGC3GZcnpBZPpci+h/Wj/oLqEDlUnY5IAv8trGAS7NMp5DZ9QMsKmY3MSVs04/1HRu3jk/J+kbZ8zNK7jA4n0tojrizw9DqDD6CgoxbiGfcWsiUw4BCpEH0XqyJyIx1j3VITCysCUqmfHULammfAoqPlEzECuJ6paLxSQksIXSyWQ6HIt3yPxSIL+GQfl0An7XpNEwyLFnLBapbgU+LFVjZLcmGZVnlm6mYbvIsEUOwG1lrKGkJlMXu1fm8jWfDqO0erGwfdZthO/qMP+Vpipp3+k61QsKy6Yxfh79enUmJwSKzpUgbtk0kzFc8od5XDI1Mi2S84pbPuTulcZwMzFr9d2hbx9mUuF+oreK1vXsufZpW0fdq9ZrgFhIssGI30MRuGtHAsWjxXPJsS6mPtcwTtatd7PPuFG8XpLN8PFZbnl2odvV4pKL+uiDFwtDfZz01+4fEBqfUa6T9Q99XLX2TJnpTNb3q8KtMPTyqB6lbmlCCwjyLuEzb8Kv03HeveBxLgRtuLaZciQUYWw4b+sb7tzf9/55JzIyJ5VHj+I+PS+EkPTgQ906DIyakxItXOQFapJcMwJfidOZbseHfON2GTfiYCbZngJWVENB4rpFzyXIGOpU7aB4x3IZl6bPuPdu/AiOWLYS7dSuIXL63oLXNjVroWl7cVpdRbdJTfwqWx6jOZWbFgkcWP0dgTHGV+cxl7gZIMof4Rt3nNs3tpTGQzOXGRcxn++MXE3yTs3+fujfzO7aANAVuAe7Vh1zIuOE92ZI+OyBcolQ1hqzwKodwy3WDdKfVkUCVfFeQgnIV+ghJKhHM3KuQP8NLuOE17BaWPFrXzXU3yOGD2JTdvxJ8mfHEVBitv/vvyNyfx3c/AcpVoXRuDgAA"; }
		}

	public override void Up()
        {
            AddColumn("dbo.People", "age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "age");
        }
    }
}
