using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003511 RID: 13585
	[Token(Token = "0x2003511")]
	public class UICharacterProfessionFilterHolder : UICharacterFilterHolder, IHotfixable
	{
		// Token: 0x06015AA4 RID: 88740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AA4")]
		[Address(RVA = "0xE3D550", Offset = "0xE3C150", VA = "0x180E3D550")]
		public void ApplyChanges(UICharacterProfessionFilterHolder.ChangeOptions options)
		{
		}

		// Token: 0x06015AA5 RID: 88741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AA5")]
		[Address(RVA = "0xE3E880", Offset = "0xE3D480", VA = "0x180E3E880")]
		private void _Reset(bool isShow, UICharacterProfessionFilterHolder.FilterParam resetFilterParam)
		{
		}

		// Token: 0x06015AA6 RID: 88742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AA6")]
		[Address(RVA = "0xE3DFE0", Offset = "0xE3CBE0", VA = "0x180E3DFE0")]
		private void _ApplyValidSubProf(HashSet<string> validSubProfs)
		{
		}

		// Token: 0x06015AA7 RID: 88743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AA7")]
		[Address(RVA = "0xE3DAB0", Offset = "0xE3C6B0", VA = "0x180E3DAB0")]
		private void _ApplyBannedProf(ProfessionCategory bannedProfs)
		{
		}

		// Token: 0x06015AA8 RID: 88744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AA8")]
		[Address(RVA = "0xE3DEB0", Offset = "0xE3CAB0", VA = "0x180E3DEB0")]
		private void _ApplyFilterShow(bool isShow)
		{
		}

		// Token: 0x06015AA9 RID: 88745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AA9")]
		[Address(RVA = "0xE3D710", Offset = "0xE3C310", VA = "0x180E3D710")]
		protected void OnCreate(bool enableValidSubProf)
		{
		}

		// Token: 0x06015AAA RID: 88746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AAA")]
		[Address(RVA = "0xE3DB80", Offset = "0xE3C780", VA = "0x180E3DB80")]
		private void _ApplyData()
		{
		}

		// Token: 0x06015AAB RID: 88747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AAB")]
		[Address(RVA = "0xE3E290", Offset = "0xE3CE90", VA = "0x180E3E290")]
		private void _OnBarTopClick()
		{
		}

		// Token: 0x06015AAC RID: 88748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AAC")]
		[Address(RVA = "0xE3E600", Offset = "0xE3D200", VA = "0x180E3E600")]
		private void _OnProfessionClick(ProfessionCategory profession, bool isAll)
		{
		}

		// Token: 0x06015AAD RID: 88749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AAD")]
		[Address(RVA = "0xE3E760", Offset = "0xE3D360", VA = "0x180E3E760")]
		private void _OnSubProfessionClick(string subProfId, bool isAll)
		{
		}

		// Token: 0x06015AAE RID: 88750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AAE")]
		[Address(RVA = "0xE3E550", Offset = "0xE3D150", VA = "0x180E3E550")]
		private void _OnCloseSubProfPanel()
		{
		}

		// Token: 0x06015AAF RID: 88751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AAF")]
		[Address(RVA = "0xE3EAC0", Offset = "0xE3D6C0", VA = "0x180E3EAC0")]
		public UICharacterProfessionFilterHolder()
		{
		}

		// Token: 0x04019FDE RID: 106462
		[Token(Token = "0x4019FDE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterProfessionFilterView _filterView;

		// Token: 0x04019FDF RID: 106463
		[Token(Token = "0x4019FDF")]
		[FieldOffset(Offset = "0x30")]
		private UICharacterProfessionFilterProperty m_prop;

		// Token: 0x04019FE0 RID: 106464
		[Token(Token = "0x4019FE0")]
		[FieldOffset(Offset = "0x38")]
		private UICharacterProfessionFilterHolder.FilterParam m_cachedFilterParam;

		// Token: 0x04019FE1 RID: 106465
		[Token(Token = "0x4019FE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyChanges;

		// Token: 0x04019FE2 RID: 106466
		[Token(Token = "0x4019FE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x04019FE3 RID: 106467
		[Token(Token = "0x4019FE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyValidSubProf;

		// Token: 0x04019FE4 RID: 106468
		[Token(Token = "0x4019FE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyBannedProf;

		// Token: 0x04019FE5 RID: 106469
		[Token(Token = "0x4019FE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ApplyFilterShow;

		// Token: 0x04019FE6 RID: 106470
		[Token(Token = "0x4019FE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04019FE7 RID: 106471
		[Token(Token = "0x4019FE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ApplyData;

		// Token: 0x04019FE8 RID: 106472
		[Token(Token = "0x4019FE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBarTopClick;

		// Token: 0x04019FE9 RID: 106473
		[Token(Token = "0x4019FE9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnProfessionClick;

		// Token: 0x04019FEA RID: 106474
		[Token(Token = "0x4019FEA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSubProfessionClick;

		// Token: 0x04019FEB RID: 106475
		[Token(Token = "0x4019FEB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnCloseSubProfPanel;

		// Token: 0x04019FEC RID: 106476
		[Token(Token = "0x4019FEC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003512 RID: 13586
		[Token(Token = "0x2003512")]
		public interface IProfFilterHandler : UICharacterFilterHolder.IFilterHandler, IHotfixable
		{
			// Token: 0x06015AB0 RID: 88752
			[Token(Token = "0x6015AB0")]
			void OnProfPanelChanged(bool isShow);
		}

		// Token: 0x02003513 RID: 13587
		[Token(Token = "0x2003513")]
		public class FilterParam : IHotfixable
		{
			// Token: 0x06015AB1 RID: 88753 RVA: 0x0008D5D0 File Offset: 0x0008B7D0
			[Token(Token = "0x6015AB1")]
			[Address(RVA = "0xE38CF0", Offset = "0xE378F0", VA = "0x180E38CF0")]
			private bool _IsProfessionIncluded(ProfessionCategory prof)
			{
				return default(bool);
			}

			// Token: 0x06015AB2 RID: 88754 RVA: 0x0008D5E8 File Offset: 0x0008B7E8
			[Token(Token = "0x6015AB2")]
			[Address(RVA = "0xE38DA0", Offset = "0xE379A0", VA = "0x180E38DA0")]
			private bool _IsSubProfessionIncluded(string id)
			{
				return default(bool);
			}

			// Token: 0x06015AB3 RID: 88755 RVA: 0x0008D600 File Offset: 0x0008B800
			[Token(Token = "0x6015AB3")]
			[Address(RVA = "0xE38920", Offset = "0xE37520", VA = "0x180E38920")]
			public bool IsIncluded(CharacterCardViewModel charCard)
			{
				return default(bool);
			}

			// Token: 0x06015AB4 RID: 88756 RVA: 0x0008D618 File Offset: 0x0008B818
			[Token(Token = "0x6015AB4")]
			[Address(RVA = "0xE38B40", Offset = "0xE37740", VA = "0x180E38B40")]
			public bool IsIncluded(ProfessionCategory prof, string subProfId)
			{
				return default(bool);
			}

			// Token: 0x06015AB5 RID: 88757 RVA: 0x0008D630 File Offset: 0x0008B830
			[Token(Token = "0x6015AB5")]
			[Address(RVA = "0xE38880", Offset = "0xE37480", VA = "0x180E38880")]
			public bool IsEquals(UICharacterProfessionFilterHolder.FilterParam newParam)
			{
				return default(bool);
			}

			// Token: 0x06015AB6 RID: 88758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015AB6")]
			[Address(RVA = "0xE38E30", Offset = "0xE37A30", VA = "0x180E38E30")]
			public FilterParam()
			{
			}

			// Token: 0x04019FED RID: 106477
			[Token(Token = "0x4019FED")]
			[FieldOffset(Offset = "0x10")]
			public bool isAll;

			// Token: 0x04019FEE RID: 106478
			[Token(Token = "0x4019FEE")]
			[FieldOffset(Offset = "0x14")]
			public ProfessionCategory profession;

			// Token: 0x04019FEF RID: 106479
			[Token(Token = "0x4019FEF")]
			[FieldOffset(Offset = "0x18")]
			public string subProfessionId;

			// Token: 0x04019FF0 RID: 106480
			[Token(Token = "0x4019FF0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__IsProfessionIncluded;

			// Token: 0x04019FF1 RID: 106481
			[Token(Token = "0x4019FF1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__IsSubProfessionIncluded;

			// Token: 0x04019FF2 RID: 106482
			[Token(Token = "0x4019FF2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsIncluded;

			// Token: 0x04019FF3 RID: 106483
			[Token(Token = "0x4019FF3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix1_IsIncluded;

			// Token: 0x04019FF4 RID: 106484
			[Token(Token = "0x4019FF4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsEquals;

			// Token: 0x04019FF5 RID: 106485
			[Token(Token = "0x4019FF5")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003514 RID: 13588
		[Token(Token = "0x2003514")]
		public struct Builder
		{
			// Token: 0x06015AB7 RID: 88759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015AB7")]
			[Address(RVA = "0xE301B0", Offset = "0xE2EDB0", VA = "0x180E301B0")]
			public UICharacterProfessionFilterHolder Build()
			{
				return null;
			}

			// Token: 0x04019FF6 RID: 106486
			[Token(Token = "0x4019FF6")]
			[FieldOffset(Offset = "0x0")]
			public UICharacterProfessionFilterHolder prefab;

			// Token: 0x04019FF7 RID: 106487
			[Token(Token = "0x4019FF7")]
			[FieldOffset(Offset = "0x8")]
			public RectTransform container;

			// Token: 0x04019FF8 RID: 106488
			[Token(Token = "0x4019FF8")]
			[FieldOffset(Offset = "0x10")]
			public ILoadAsset assetLoader;

			// Token: 0x04019FF9 RID: 106489
			[Token(Token = "0x4019FF9")]
			[FieldOffset(Offset = "0x18")]
			public UICharacterFilterHolder.IFilterHandler filterHandler;

			// Token: 0x04019FFA RID: 106490
			[Token(Token = "0x4019FFA")]
			[FieldOffset(Offset = "0x20")]
			public bool enableValidSubProf;
		}

		// Token: 0x02003515 RID: 13589
		[Token(Token = "0x2003515")]
		public struct ChangeOptions
		{
			// Token: 0x04019FFB RID: 106491
			[Token(Token = "0x4019FFB")]
			[FieldOffset(Offset = "0x0")]
			public HashSet<string> validSubProfs;

			// Token: 0x04019FFC RID: 106492
			[Token(Token = "0x4019FFC")]
			[FieldOffset(Offset = "0x8")]
			public ProfessionCategory bannedProfs;

			// Token: 0x04019FFD RID: 106493
			[Token(Token = "0x4019FFD")]
			[FieldOffset(Offset = "0xC")]
			public bool needReset;

			// Token: 0x04019FFE RID: 106494
			[Token(Token = "0x4019FFE")]
			[FieldOffset(Offset = "0xD")]
			public bool resetShow;

			// Token: 0x04019FFF RID: 106495
			[Token(Token = "0x4019FFF")]
			[FieldOffset(Offset = "0x10")]
			public UICharacterProfessionFilterHolder.FilterParam resetFilterParam;
		}
	}
}
