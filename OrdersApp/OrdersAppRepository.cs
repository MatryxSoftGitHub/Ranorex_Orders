﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace OrdersApp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the OrdersAppRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("9364e3d7-b3be-49e3-b76d-593ec4891f46")]
    public partial class OrdersAppRepository : RepoGenBaseFolder
    {
        static OrdersAppRepository instance = new OrdersAppRepository();
        OrdersAppRepositoryFolders.OrdersApplicationAppFolder _ordersapplication;
        OrdersAppRepositoryFolders.OrdersAppFolder _orders;
        OrdersAppRepositoryFolders.NewOrderAppFolder _neworder;
        OrdersAppRepositoryFolders.SelectProductAppFolder _selectproduct;
        OrdersAppRepositoryFolders.Orders_SaveDilogAppFolder _orders_savedilog;

        /// <summary>
        /// Gets the singleton class instance representing the OrdersAppRepository element repository.
        /// </summary>
        [RepositoryFolder("9364e3d7-b3be-49e3-b76d-593ec4891f46")]
        public static OrdersAppRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public OrdersAppRepository() 
            : base("OrdersAppRepository", "/", null, 0, false, "9364e3d7-b3be-49e3-b76d-593ec4891f46", ".\\RepositoryImages\\OrdersAppRepository9364e3d7.rximgres")
        {
            _ordersapplication = new OrdersAppRepositoryFolders.OrdersApplicationAppFolder(this);
            _orders = new OrdersAppRepositoryFolders.OrdersAppFolder(this);
            _neworder = new OrdersAppRepositoryFolders.NewOrderAppFolder(this);
            _selectproduct = new OrdersAppRepositoryFolders.SelectProductAppFolder(this);
            _orders_savedilog = new OrdersAppRepositoryFolders.Orders_SaveDilogAppFolder(this);
        }

#region Variables

        string _Card = "VISA";

        /// <summary>
        /// Gets or sets the value of variable Card.
        /// </summary>
        [TestVariable("ae6a88aa-f041-487e-8781-251713f8bdf4")]
        public string Card
        {
            get { return _Card; }
            set { _Card = value; }
        }

        string _Product = "FamilyAlbum";

        /// <summary>
        /// Gets or sets the value of variable Product.
        /// </summary>
        [TestVariable("203a17ff-6160-4ec8-a0a1-acf147b80854")]
        public string Product
        {
            get { return _Product; }
            set { _Product = value; }
        }

        string _Date = "24";

        /// <summary>
        /// Gets or sets the value of variable Date.
        /// </summary>
        [TestVariable("47b5641e-7974-482a-af37-5ada48aaae77")]
        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        string _C_Variable = "gbr";

        /// <summary>
        /// Gets or sets the value of variable C_Variable.
        /// </summary>
        [TestVariable("5dff2f0c-f53c-41fd-84e7-cbf245541c76")]
        public string C_Variable
        {
            get { return _C_Variable; }
            set { _C_Variable = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("9364e3d7-b3be-49e3-b76d-593ec4891f46")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The OrdersApplication folder.
        /// </summary>
        [RepositoryFolder("79a48627-8f67-4dec-8211-53438b0d81db")]
        public virtual OrdersAppRepositoryFolders.OrdersApplicationAppFolder OrdersApplication
        {
            get { return _ordersapplication; }
        }

        /// <summary>
        /// The Orders folder.
        /// </summary>
        [RepositoryFolder("0cc29327-377f-45f6-a245-4d0d4b4f7544")]
        public virtual OrdersAppRepositoryFolders.OrdersAppFolder Orders
        {
            get { return _orders; }
        }

        /// <summary>
        /// The NewOrder folder.
        /// </summary>
        [RepositoryFolder("64bb8a49-d3bd-4c4d-9919-b430cdb35910")]
        public virtual OrdersAppRepositoryFolders.NewOrderAppFolder NewOrder
        {
            get { return _neworder; }
        }

        /// <summary>
        /// The SelectProduct folder.
        /// </summary>
        [RepositoryFolder("b82df9eb-7858-4364-ae26-58c94ea26993")]
        public virtual OrdersAppRepositoryFolders.SelectProductAppFolder SelectProduct
        {
            get { return _selectproduct; }
        }

        /// <summary>
        /// The Orders_SaveDilog folder.
        /// </summary>
        [RepositoryFolder("c9783772-322b-47d8-9fc5-5f0e72af670d")]
        public virtual OrdersAppRepositoryFolders.Orders_SaveDilogAppFolder Orders_SaveDilog
        {
            get { return _orders_savedilog; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class OrdersAppRepositoryFolders
    {
        /// <summary>
        /// The OrdersApplicationAppFolder folder.
        /// </summary>
        [RepositoryFolder("79a48627-8f67-4dec-8211-53438b0d81db")]
        public partial class OrdersApplicationAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btn_maximizeInfo;
            RepoItemInfo _ordersInfo;
            RepoItemInfo _list_viewInfo;

            /// <summary>
            /// Creates a new OrdersApplication  folder.
            /// </summary>
            public OrdersApplicationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("OrdersApplication", "/form[@title='Untitled - Orders']", parentFolder, 30000, null, true, "79a48627-8f67-4dec-8211-53438b0d81db", "")
            {
                _btn_maximizeInfo = new RepoItemInfo(this, "Btn_Maximize", "?/?/button[@accessiblename='Maximize']", 30000, null, "7bbae93a-3cb2-414b-8043-255397cb0fa7");
                _ordersInfo = new RepoItemInfo(this, "Orders", "?/?/menuitem[@accessiblename='Orders']", 30000, null, "3d172288-57a7-425a-b28c-e127d0077700");
                _list_viewInfo = new RepoItemInfo(this, "List_View", "table[@controlid='59648']", 30000, null, "47bf6d55-4d3a-48eb-a594-28b9b3cf7974");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("79a48627-8f67-4dec-8211-53438b0d81db")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("79a48627-8f67-4dec-8211-53438b0d81db")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Btn_Maximize item.
            /// </summary>
            [RepositoryItem("7bbae93a-3cb2-414b-8043-255397cb0fa7")]
            public virtual Ranorex.Button Btn_Maximize
            {
                get
                {
                    return _btn_maximizeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Btn_Maximize item info.
            /// </summary>
            [RepositoryItemInfo("7bbae93a-3cb2-414b-8043-255397cb0fa7")]
            public virtual RepoItemInfo Btn_MaximizeInfo
            {
                get
                {
                    return _btn_maximizeInfo;
                }
            }

            /// <summary>
            /// The Orders item.
            /// </summary>
            [RepositoryItem("3d172288-57a7-425a-b28c-e127d0077700")]
            public virtual Ranorex.MenuItem Orders
            {
                get
                {
                    return _ordersInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Orders item info.
            /// </summary>
            [RepositoryItemInfo("3d172288-57a7-425a-b28c-e127d0077700")]
            public virtual RepoItemInfo OrdersInfo
            {
                get
                {
                    return _ordersInfo;
                }
            }

            /// <summary>
            /// The List_View item.
            /// </summary>
            [RepositoryItem("47bf6d55-4d3a-48eb-a594-28b9b3cf7974")]
            public virtual Ranorex.Table List_View
            {
                get
                {
                    return _list_viewInfo.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The List_View item info.
            /// </summary>
            [RepositoryItemInfo("47bf6d55-4d3a-48eb-a594-28b9b3cf7974")]
            public virtual RepoItemInfo List_ViewInfo
            {
                get
                {
                    return _list_viewInfo;
                }
            }
        }

        /// <summary>
        /// The OrdersAppFolder folder.
        /// </summary>
        [RepositoryFolder("0cc29327-377f-45f6-a245-4d0d4b4f7544")]
        public partial class OrdersAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _new_orderInfo;
            RepoItemInfo _openctrlplusoInfo;

            /// <summary>
            /// Creates a new Orders  folder.
            /// </summary>
            public OrdersAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Orders", "/contextmenu[@processname='Orders']", parentFolder, 30000, null, false, "0cc29327-377f-45f6-a245-4d0d4b4f7544", "")
            {
                _new_orderInfo = new RepoItemInfo(this, "New_Order", "?/?/menuitem[@accessiblename='New order...Ctrl+Ins']", 30000, null, "8aa414f6-824a-450b-ad0a-6e817c05bc64");
                _openctrlplusoInfo = new RepoItemInfo(this, "OpenCtrlPlusO", "?/?/menuitem[@accessiblename='Open...Ctrl+O']", 30000, null, "13201f76-d29c-4345-aaf4-13ff30690cfb");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0cc29327-377f-45f6-a245-4d0d4b4f7544")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("0cc29327-377f-45f6-a245-4d0d4b4f7544")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The New_Order item.
            /// </summary>
            [RepositoryItem("8aa414f6-824a-450b-ad0a-6e817c05bc64")]
            public virtual Ranorex.MenuItem New_Order
            {
                get
                {
                    return _new_orderInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The New_Order item info.
            /// </summary>
            [RepositoryItemInfo("8aa414f6-824a-450b-ad0a-6e817c05bc64")]
            public virtual RepoItemInfo New_OrderInfo
            {
                get
                {
                    return _new_orderInfo;
                }
            }

            /// <summary>
            /// The OpenCtrlPlusO item.
            /// </summary>
            [RepositoryItem("13201f76-d29c-4345-aaf4-13ff30690cfb")]
            public virtual Ranorex.MenuItem OpenCtrlPlusO
            {
                get
                {
                    return _openctrlplusoInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The OpenCtrlPlusO item info.
            /// </summary>
            [RepositoryItemInfo("13201f76-d29c-4345-aaf4-13ff30690cfb")]
            public virtual RepoItemInfo OpenCtrlPlusOInfo
            {
                get
                {
                    return _openctrlplusoInfo;
                }
            }
        }

        /// <summary>
        /// The NewOrderAppFolder folder.
        /// </summary>
        [RepositoryFolder("64bb8a49-d3bd-4c4d-9919-b430cdb35910")]
        public partial class NewOrderAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _sstartdate_dateInfo;
            RepoItemInfo _scustomernameInfo;
            RepoItemInfo _sstreetInfo;
            RepoItemInfo _scityInfo;
            RepoItemInfo _sstateInfo;
            RepoItemInfo _szipInfo;
            RepoItemInfo _scardnumInfo;
            RepoItemInfo _sexpirationdate_dateInfo;
            RepoItemInfo _btn_okInfo;
            RepoItemInfo _sstartdate_monthInfo;
            RepoItemInfo _cbo_producttypeInfo;
            RepoItemInfo _sstartdate_yearInfo;
            RepoItemInfo _sexpirationdate_monthInfo;
            RepoItemInfo _sexpirationdate_yearInfo;
            RepoItemInfo _rbtn_visaInfo;
            RepoItemInfo _rbtn_mastercardInfo;
            RepoItemInfo _rbtn_americanexpressInfo;

            /// <summary>
            /// Creates a new NewOrder  folder.
            /// </summary>
            public NewOrderAppFolder(RepoGenBaseFolder parentFolder) :
                    base("NewOrder", "/form[@title='New order']", parentFolder, 30000, null, true, "64bb8a49-d3bd-4c4d-9919-b430cdb35910", "")
            {
                _sstartdate_dateInfo = new RepoItemInfo(this, "sStartDate_Date", "element[@controlid='1003']/rawtext[@rawtext~'.$'][1]", 30000, null, "11dd8829-54e3-4daa-9c9d-c3e5e7eab5cb");
                _scustomernameInfo = new RepoItemInfo(this, "sCustomerName", "text[@controlid='1006']", 30000, null, "5fcce0e8-1e4d-4d75-9d70-93499ed2a85c");
                _sstreetInfo = new RepoItemInfo(this, "sStreet", "text[@controlid='1007']", 30000, null, "3c349cea-0fb8-4f9b-af6c-ae772086f2f2");
                _scityInfo = new RepoItemInfo(this, "sCity", "text[@controlid='1008']", 30000, null, "3aaa7253-ebcf-4f0b-a789-30f93a4ef44b");
                _sstateInfo = new RepoItemInfo(this, "sState", "text[@controlid='1009']", 30000, null, "5ced3a66-d5e0-4092-ac62-05a320684c3d");
                _szipInfo = new RepoItemInfo(this, "sZip", "text[@controlid='1010']", 30000, null, "f99322e3-72e5-4ae2-9840-a316246ad575");
                _scardnumInfo = new RepoItemInfo(this, "sCardNum", "text[@controlid='1011']", 30000, null, "7bebf207-b001-4845-91ac-ee0a119c551d");
                _sexpirationdate_dateInfo = new RepoItemInfo(this, "sExpirationDate_Date", "element[@controlid='1015']/rawtext[@rawtext~'.$'][1]", 30000, null, "9d4a0ddf-f372-4569-a82f-7d50086394b2");
                _btn_okInfo = new RepoItemInfo(this, "Btn_OK", "button[@text='OK']", 30000, null, "097dca36-3c02-4acc-9b65-1a4546aa2801");
                _sstartdate_monthInfo = new RepoItemInfo(this, "sStartDate_Month", "element[@controlid='1003']/rawtext[@rawtext~'[0-12]'][2]", 30000, null, "1340a1ce-542e-4a13-9180-b3debd8387b4");
                _cbo_producttypeInfo = new RepoItemInfo(this, "Cbo_ProductType", "combobox[@controlid='1000']", 30000, null, "e3a3fb98-c791-4fa3-b1c2-cd6b64c6f9a0");
                _sstartdate_yearInfo = new RepoItemInfo(this, "sStartDate_Year", "element[@controlid='1003']/rawtext[@rawtext~'....']", 30000, null, "1887b0cd-cc02-4ac8-8c9a-63b6e092cefc");
                _sexpirationdate_monthInfo = new RepoItemInfo(this, "sExpirationDate_Month", "element[@controlid='1015']/rawtext[@rawtext~'[0-12]'][2]", 30000, null, "49a3ba4a-6acc-4e8c-88b8-d5252f5472bc");
                _sexpirationdate_yearInfo = new RepoItemInfo(this, "sExpirationDate_Year", "element[@controlid='1015']/rawtext[@rawtext~'....']", 30000, null, "a2e0396a-fb41-44af-a9de-0fe136f04069");
                _rbtn_visaInfo = new RepoItemInfo(this, "Rbtn_VISA", "radiobutton[@text='VISA']", 30000, null, "32c6edf1-7b62-48f7-8d12-747ae1a8f201");
                _rbtn_mastercardInfo = new RepoItemInfo(this, "Rbtn_MasterCard", "radiobutton[@text='Master Card']", 30000, null, "462939b4-9eae-44fb-a3f1-84fa8943b688");
                _rbtn_americanexpressInfo = new RepoItemInfo(this, "Rbtn_AmericanExpress", "radiobutton[@text='American Express']", 30000, null, "b3495efc-e483-43fe-876d-bb55644b1ffc");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("64bb8a49-d3bd-4c4d-9919-b430cdb35910")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("64bb8a49-d3bd-4c4d-9919-b430cdb35910")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The sStartDate_Date item.
            /// </summary>
            [RepositoryItem("11dd8829-54e3-4daa-9c9d-c3e5e7eab5cb")]
            public virtual Ranorex.RawText sStartDate_Date
            {
                get
                {
                    return _sstartdate_dateInfo.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The sStartDate_Date item info.
            /// </summary>
            [RepositoryItemInfo("11dd8829-54e3-4daa-9c9d-c3e5e7eab5cb")]
            public virtual RepoItemInfo sStartDate_DateInfo
            {
                get
                {
                    return _sstartdate_dateInfo;
                }
            }

            /// <summary>
            /// The sCustomerName item.
            /// </summary>
            [RepositoryItem("5fcce0e8-1e4d-4d75-9d70-93499ed2a85c")]
            public virtual Ranorex.Text sCustomerName
            {
                get
                {
                    return _scustomernameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The sCustomerName item info.
            /// </summary>
            [RepositoryItemInfo("5fcce0e8-1e4d-4d75-9d70-93499ed2a85c")]
            public virtual RepoItemInfo sCustomerNameInfo
            {
                get
                {
                    return _scustomernameInfo;
                }
            }

            /// <summary>
            /// The sStreet item.
            /// </summary>
            [RepositoryItem("3c349cea-0fb8-4f9b-af6c-ae772086f2f2")]
            public virtual Ranorex.Text sStreet
            {
                get
                {
                    return _sstreetInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The sStreet item info.
            /// </summary>
            [RepositoryItemInfo("3c349cea-0fb8-4f9b-af6c-ae772086f2f2")]
            public virtual RepoItemInfo sStreetInfo
            {
                get
                {
                    return _sstreetInfo;
                }
            }

            /// <summary>
            /// The sCity item.
            /// </summary>
            [RepositoryItem("3aaa7253-ebcf-4f0b-a789-30f93a4ef44b")]
            public virtual Ranorex.Text sCity
            {
                get
                {
                    return _scityInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The sCity item info.
            /// </summary>
            [RepositoryItemInfo("3aaa7253-ebcf-4f0b-a789-30f93a4ef44b")]
            public virtual RepoItemInfo sCityInfo
            {
                get
                {
                    return _scityInfo;
                }
            }

            /// <summary>
            /// The sState item.
            /// </summary>
            [RepositoryItem("5ced3a66-d5e0-4092-ac62-05a320684c3d")]
            public virtual Ranorex.Text sState
            {
                get
                {
                    return _sstateInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The sState item info.
            /// </summary>
            [RepositoryItemInfo("5ced3a66-d5e0-4092-ac62-05a320684c3d")]
            public virtual RepoItemInfo sStateInfo
            {
                get
                {
                    return _sstateInfo;
                }
            }

            /// <summary>
            /// The sZip item.
            /// </summary>
            [RepositoryItem("f99322e3-72e5-4ae2-9840-a316246ad575")]
            public virtual Ranorex.Text sZip
            {
                get
                {
                    return _szipInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The sZip item info.
            /// </summary>
            [RepositoryItemInfo("f99322e3-72e5-4ae2-9840-a316246ad575")]
            public virtual RepoItemInfo sZipInfo
            {
                get
                {
                    return _szipInfo;
                }
            }

            /// <summary>
            /// The sCardNum item.
            /// </summary>
            [RepositoryItem("7bebf207-b001-4845-91ac-ee0a119c551d")]
            public virtual Ranorex.Text sCardNum
            {
                get
                {
                    return _scardnumInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The sCardNum item info.
            /// </summary>
            [RepositoryItemInfo("7bebf207-b001-4845-91ac-ee0a119c551d")]
            public virtual RepoItemInfo sCardNumInfo
            {
                get
                {
                    return _scardnumInfo;
                }
            }

            /// <summary>
            /// The sExpirationDate_Date item.
            /// </summary>
            [RepositoryItem("9d4a0ddf-f372-4569-a82f-7d50086394b2")]
            public virtual Ranorex.RawText sExpirationDate_Date
            {
                get
                {
                    return _sexpirationdate_dateInfo.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The sExpirationDate_Date item info.
            /// </summary>
            [RepositoryItemInfo("9d4a0ddf-f372-4569-a82f-7d50086394b2")]
            public virtual RepoItemInfo sExpirationDate_DateInfo
            {
                get
                {
                    return _sexpirationdate_dateInfo;
                }
            }

            /// <summary>
            /// The Btn_OK item.
            /// </summary>
            [RepositoryItem("097dca36-3c02-4acc-9b65-1a4546aa2801")]
            public virtual Ranorex.Button Btn_OK
            {
                get
                {
                    return _btn_okInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Btn_OK item info.
            /// </summary>
            [RepositoryItemInfo("097dca36-3c02-4acc-9b65-1a4546aa2801")]
            public virtual RepoItemInfo Btn_OKInfo
            {
                get
                {
                    return _btn_okInfo;
                }
            }

            /// <summary>
            /// The sStartDate_Month item.
            /// </summary>
            [RepositoryItem("1340a1ce-542e-4a13-9180-b3debd8387b4")]
            public virtual Ranorex.RawText sStartDate_Month
            {
                get
                {
                    return _sstartdate_monthInfo.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The sStartDate_Month item info.
            /// </summary>
            [RepositoryItemInfo("1340a1ce-542e-4a13-9180-b3debd8387b4")]
            public virtual RepoItemInfo sStartDate_MonthInfo
            {
                get
                {
                    return _sstartdate_monthInfo;
                }
            }

            /// <summary>
            /// The Cbo_ProductType item.
            /// </summary>
            [RepositoryItem("e3a3fb98-c791-4fa3-b1c2-cd6b64c6f9a0")]
            public virtual Ranorex.ComboBox Cbo_ProductType
            {
                get
                {
                    return _cbo_producttypeInfo.CreateAdapter<Ranorex.ComboBox>(true);
                }
            }

            /// <summary>
            /// The Cbo_ProductType item info.
            /// </summary>
            [RepositoryItemInfo("e3a3fb98-c791-4fa3-b1c2-cd6b64c6f9a0")]
            public virtual RepoItemInfo Cbo_ProductTypeInfo
            {
                get
                {
                    return _cbo_producttypeInfo;
                }
            }

            /// <summary>
            /// The sStartDate_Year item.
            /// </summary>
            [RepositoryItem("1887b0cd-cc02-4ac8-8c9a-63b6e092cefc")]
            public virtual Ranorex.RawText sStartDate_Year
            {
                get
                {
                    return _sstartdate_yearInfo.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The sStartDate_Year item info.
            /// </summary>
            [RepositoryItemInfo("1887b0cd-cc02-4ac8-8c9a-63b6e092cefc")]
            public virtual RepoItemInfo sStartDate_YearInfo
            {
                get
                {
                    return _sstartdate_yearInfo;
                }
            }

            /// <summary>
            /// The sExpirationDate_Month item.
            /// </summary>
            [RepositoryItem("49a3ba4a-6acc-4e8c-88b8-d5252f5472bc")]
            public virtual Ranorex.RawText sExpirationDate_Month
            {
                get
                {
                    return _sexpirationdate_monthInfo.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The sExpirationDate_Month item info.
            /// </summary>
            [RepositoryItemInfo("49a3ba4a-6acc-4e8c-88b8-d5252f5472bc")]
            public virtual RepoItemInfo sExpirationDate_MonthInfo
            {
                get
                {
                    return _sexpirationdate_monthInfo;
                }
            }

            /// <summary>
            /// The sExpirationDate_Year item.
            /// </summary>
            [RepositoryItem("a2e0396a-fb41-44af-a9de-0fe136f04069")]
            public virtual Ranorex.RawText sExpirationDate_Year
            {
                get
                {
                    return _sexpirationdate_yearInfo.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The sExpirationDate_Year item info.
            /// </summary>
            [RepositoryItemInfo("a2e0396a-fb41-44af-a9de-0fe136f04069")]
            public virtual RepoItemInfo sExpirationDate_YearInfo
            {
                get
                {
                    return _sexpirationdate_yearInfo;
                }
            }

            /// <summary>
            /// The Rbtn_VISA item.
            /// </summary>
            [RepositoryItem("32c6edf1-7b62-48f7-8d12-747ae1a8f201")]
            public virtual Ranorex.RadioButton Rbtn_VISA
            {
                get
                {
                    return _rbtn_visaInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The Rbtn_VISA item info.
            /// </summary>
            [RepositoryItemInfo("32c6edf1-7b62-48f7-8d12-747ae1a8f201")]
            public virtual RepoItemInfo Rbtn_VISAInfo
            {
                get
                {
                    return _rbtn_visaInfo;
                }
            }

            /// <summary>
            /// The Rbtn_MasterCard item.
            /// </summary>
            [RepositoryItem("462939b4-9eae-44fb-a3f1-84fa8943b688")]
            public virtual Ranorex.RadioButton Rbtn_MasterCard
            {
                get
                {
                    return _rbtn_mastercardInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The Rbtn_MasterCard item info.
            /// </summary>
            [RepositoryItemInfo("462939b4-9eae-44fb-a3f1-84fa8943b688")]
            public virtual RepoItemInfo Rbtn_MasterCardInfo
            {
                get
                {
                    return _rbtn_mastercardInfo;
                }
            }

            /// <summary>
            /// The Rbtn_AmericanExpress item.
            /// </summary>
            [RepositoryItem("b3495efc-e483-43fe-876d-bb55644b1ffc")]
            public virtual Ranorex.RadioButton Rbtn_AmericanExpress
            {
                get
                {
                    return _rbtn_americanexpressInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The Rbtn_AmericanExpress item info.
            /// </summary>
            [RepositoryItemInfo("b3495efc-e483-43fe-876d-bb55644b1ffc")]
            public virtual RepoItemInfo Rbtn_AmericanExpressInfo
            {
                get
                {
                    return _rbtn_americanexpressInfo;
                }
            }
        }

        /// <summary>
        /// The SelectProductAppFolder folder.
        /// </summary>
        [RepositoryFolder("b82df9eb-7858-4364-ae26-58c94ea26993")]
        public partial class SelectProductAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _productInfo;

            /// <summary>
            /// Creates a new SelectProduct  folder.
            /// </summary>
            public SelectProductAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SelectProduct", "/list[@controlid='1000']", parentFolder, 30000, null, true, "b82df9eb-7858-4364-ae26-58c94ea26993", "")
            {
                _productInfo = new RepoItemInfo(this, "Product", "listitem[@text=$Product]", 30000, null, "fa5ddae6-c29c-4219-b54e-12ffc77db434");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b82df9eb-7858-4364-ae26-58c94ea26993")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b82df9eb-7858-4364-ae26-58c94ea26993")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Product item.
            /// </summary>
            [RepositoryItem("fa5ddae6-c29c-4219-b54e-12ffc77db434")]
            public virtual Ranorex.ListItem Product
            {
                get
                {
                    return _productInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Product item info.
            /// </summary>
            [RepositoryItemInfo("fa5ddae6-c29c-4219-b54e-12ffc77db434")]
            public virtual RepoItemInfo ProductInfo
            {
                get
                {
                    return _productInfo;
                }
            }
        }

        /// <summary>
        /// The Orders_SaveDilogAppFolder folder.
        /// </summary>
        [RepositoryFolder("c9783772-322b-47d8-9fc5-5f0e72af670d")]
        public partial class Orders_SaveDilogAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btn_noInfo;
            RepoItemInfo _btn_yesInfo;

            /// <summary>
            /// Creates a new Orders_SaveDilog  folder.
            /// </summary>
            public Orders_SaveDilogAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Orders_SaveDilog", "/form[@title='Orders']", parentFolder, 30000, null, true, "c9783772-322b-47d8-9fc5-5f0e72af670d", "")
            {
                _btn_noInfo = new RepoItemInfo(this, "Btn_No", "button[@text='&No']", 30000, null, "54c851cb-db53-499a-b41a-7d9d9fd0df4c");
                _btn_yesInfo = new RepoItemInfo(this, "Btn_Yes", "button[@text='&Yes']", 30000, null, "980ea604-e9fc-4a7e-aefd-f084ebcf1fe9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c9783772-322b-47d8-9fc5-5f0e72af670d")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c9783772-322b-47d8-9fc5-5f0e72af670d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Btn_No item.
            /// </summary>
            [RepositoryItem("54c851cb-db53-499a-b41a-7d9d9fd0df4c")]
            public virtual Ranorex.Button Btn_No
            {
                get
                {
                    return _btn_noInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Btn_No item info.
            /// </summary>
            [RepositoryItemInfo("54c851cb-db53-499a-b41a-7d9d9fd0df4c")]
            public virtual RepoItemInfo Btn_NoInfo
            {
                get
                {
                    return _btn_noInfo;
                }
            }

            /// <summary>
            /// The Btn_Yes item.
            /// </summary>
            [RepositoryItem("980ea604-e9fc-4a7e-aefd-f084ebcf1fe9")]
            public virtual Ranorex.Button Btn_Yes
            {
                get
                {
                    return _btn_yesInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Btn_Yes item info.
            /// </summary>
            [RepositoryItemInfo("980ea604-e9fc-4a7e-aefd-f084ebcf1fe9")]
            public virtual RepoItemInfo Btn_YesInfo
            {
                get
                {
                    return _btn_yesInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}