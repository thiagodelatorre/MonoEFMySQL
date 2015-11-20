using System.Data.Entity.Migrations.Infrastructure;

namespace EF
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastName : DbMigration, IMigrationMetadata
    {
        string IMigrationMetadata.Id {
			get { return "201511200204384_LastName"; } } 

		string IMigrationMetadata.Source { get { return null; }}

		string IMigrationMetadata.Target { get { return "H4sIAAAAAAAAA81X3U7bMBS+n7R3sHzN4gLatKEExAqd0ChUhO3eTU6LNcfOYge1z7aLPdJeYcf5b0KhoG2aepM453zn8+fz4/768dM/WSWS3ENmhFYB3fdGlICKdCzUMqC5Xbx5T0+OX7/yz+NkRb7WdofODj2VCeidtekRYya6g4QbLxFRpo1eWC/SCeOxZgej0Qe2v88AIShiEeLf5MqKBIoXfB1rFUFqcy6nOgZpqnX8Ehao5IonYFIeQUDPJ5ScSsExcghyQQlXSltukdfRFwOhzbRahikucHm7TgHtFlwaqPgetea7Uh8dOOqsdayhotxYnTwTcP+w0oL13V+kKG20QrXOUVW7drsuFAvoDA/MAfdDHY1l5sycnF5ptEfOJ3vNCY+84rdHxrm0eQaBgtxmXO6RWT6XIvoM61v9DVSgcim7HJAFfttYwKVZplPI7PoGFhWzi5gStunH+o6NW8enZH2h7OEBJVcYnM8lNEfc2WFodQafQEHGLcQzbi1kymFAIdIgei/WRGTGusc6JCYW1gQlU766BLW0dwHFR0omYgVxvVLR+KIElhA62SyHpyJd8r8SyGdtNgxzBCvOcoHiVCSmxQqs7AO5glVVpYupAm3up0QMwW4knaGkJVDWqlen40M8G0Zt8bOy+usuwba0CX/K0xQl67SNaoWEZc8YvwmfX1xJicEi80CNNWybSJhufAm9rxgamRa5dMYtn3N3aOM4GZi1+m/Rto6zKXG/zlrFa3v3XPo0ld73avWa4BYSrI9iN9DEbvrIwLHo0Fzy7IFKHWuZJ2pbtT/m3am9LkhneXestrq6UO3qEMlnPTX6IrOByr0+1j+0x7K9b9JEb7K+l91+lWlPT8pB6pUmlKBE9yIu0y78Lj333Ssex1LghluLKVdiAcaWvZ6+9d71hu//MwiZMbHcaRr+82klnKRPzqPBMHvmgJJ47yk7eIv0kvmzG87zxsuwC+4yQh6ZIGUqBzSea+RdkpyBTuUWmjtMl2Fd+ax7T/XPwIhlC+FurQoil7AtaG1zoRa61hm31WVUm/SOYQqWx6jOaWbFgkcWP0dgTHEV+Mpl7jp4Mof4Ql3nNs3tqTGQzOXGRcZnj8cvRugmZ/86dW/mT2wBaQrcAlyrj7mQccN7MsznbRAuUaoiQVZ4FUK45bpButJqR6BKvjNIQbkSu4UklQhmrlXI7+El3PAedAlLHq3r7rgd5OmD2JTdPxN8mfHEVBitv/vvxdyfr+Pf9vDrC64NAAA="; }}

		public override void Up()
        {
            CreateTable(
                "People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
