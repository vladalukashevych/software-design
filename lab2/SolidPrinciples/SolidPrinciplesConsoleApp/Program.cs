using SolidPrinciplesConsoleApp.Money;
using SolidPrinciplesConsoleApp.Products;
using SolidPrinciplesConsoleApp.Reporting;
using SolidPrinciplesConsoleApp.Warehouse;
using static SolidPrinciplesConsoleApp.Enums;

List<IProduct> products = new List<IProduct>();
products.Add(new Food("OatMilk", "VegaMilk", 25, new Dollar(4.40m), new DateTime(2023, 5, 18)));
products.Add(new Food("MexicanMix", "Aro", 148, new Dollar(13.86m), new DateTime(2024, 11, 24)));
products.Add(new Instrument("Piano", "Yamaha", 3, new Dollar(3890), InstrumentType.Keyboards));

List<IProduct> addProducts = new List<IProduct>();
addProducts.Add(new Instrument("Guitar", "MegaGuitars", 17, new Dollar(789), InstrumentType.Strings));
addProducts.Add(new Food("Salmon", "NorthSea", 332, new Dollar(57.90m), new DateTime(2023, 12, 31)));


List<IProduct> removeProducts = new List<IProduct>();
removeProducts.Add(new Food("MexicanMix", "Aro", 148, new Dollar(13.86m), new DateTime(2024, 11, 24)));
removeProducts.Add(new Instrument("Guitar", "MegaGuitars", 17, new Dollar(789), InstrumentType.Strings));

//Dependency Inversion Principle

// High-level modules should not directly depend on low-level modules,
// but both should depend on abstractions.
// The ClassicReporting class takes an IWarehouse implementation as a
// dependency through its constructor, this allows the ClassicReporting
// to depend on an abstraction IWarehouse instead of a concrete implementation.


IWarehouse warehouse = new Warehouse(products);
IReporting reporting = new ClassicReporting();

reporting.ReleaseInventaryReport(warehouse.Products);

reporting.ReleasePurchaseInvoice(addProducts);
warehouse.AddProducts(addProducts);

reporting.ReleaseSalesInvoice(removeProducts);
warehouse.RemoveProducts(removeProducts);

reporting.ReleaseInventaryReport(warehouse.Products);