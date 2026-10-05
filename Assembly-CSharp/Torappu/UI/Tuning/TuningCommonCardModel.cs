using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C8A RID: 15498
	[Token(Token = "0x2003C8A")]
	public class TuningCommonCardModel : IHotfixable
	{
		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x06018341 RID: 99137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039C7")]
		public string productTypeBasePicId
		{
			[Token(Token = "0x6018341")]
			[Address(RVA = "0x10B3330", Offset = "0x10B1F30", VA = "0x1810B3330")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x06018342 RID: 99138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039C8")]
		public string orcheIconId
		{
			[Token(Token = "0x6018342")]
			[Address(RVA = "0x10B3270", Offset = "0x10B1E70", VA = "0x1810B3270")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x06018343 RID: 99139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039C9")]
		public List<string> fragmentIconIdList
		{
			[Token(Token = "0x6018343")]
			[Address(RVA = "0x10B31B0", Offset = "0x10B1DB0", VA = "0x1810B31B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x06018344 RID: 99140 RVA: 0x00099AC8 File Offset: 0x00097CC8
		[Token(Token = "0x170039CA")]
		public bool isChanged
		{
			[Token(Token = "0x6018344")]
			[Address(RVA = "0x10B3210", Offset = "0x10B1E10", VA = "0x1810B3210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x06018345 RID: 99141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039CB")]
		public string productTypeId
		{
			[Token(Token = "0x6018345")]
			[Address(RVA = "0x10B3390", Offset = "0x10B1F90", VA = "0x1810B3390")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x06018346 RID: 99142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039CC")]
		public string orcheId
		{
			[Token(Token = "0x6018346")]
			[Address(RVA = "0x10B32D0", Offset = "0x10B1ED0", VA = "0x1810B32D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x06018347 RID: 99143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039CD")]
		public string formId
		{
			[Token(Token = "0x6018347")]
			[Address(RVA = "0x10B3150", Offset = "0x10B1D50", VA = "0x1810B3150")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018348 RID: 99144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018348")]
		[Address(RVA = "0x10B2720", Offset = "0x10B1320", VA = "0x1810B2720")]
		public void LoadData(string actId, string productTypeId, string orcheId, string formId)
		{
		}

		// Token: 0x06018349 RID: 99145 RVA: 0x00099AE0 File Offset: 0x00097CE0
		[Token(Token = "0x6018349")]
		[Address(RVA = "0x10B2B30", Offset = "0x10B1730", VA = "0x1810B2B30")]
		private bool _CheckIsChanged(string productTypeId, string orcheId, string formId)
		{
			return default(bool);
		}

		// Token: 0x0601834A RID: 99146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601834A")]
		[Address(RVA = "0x10B2C00", Offset = "0x10B1800", VA = "0x1810B2C00")]
		private void _ClearData()
		{
		}

		// Token: 0x0601834B RID: 99147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601834B")]
		[Address(RVA = "0x10B3000", Offset = "0x10B1C00", VA = "0x1810B3000")]
		private void _LoadProductType(Act29SideData actData, string productTypeId)
		{
		}

		// Token: 0x0601834C RID: 99148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601834C")]
		[Address(RVA = "0x10B2F10", Offset = "0x10B1B10", VA = "0x1810B2F10")]
		private void _LoadOrche(Act29SideData actData, string orcheId)
		{
		}

		// Token: 0x0601834D RID: 99149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601834D")]
		[Address(RVA = "0x10B2C90", Offset = "0x10B1890", VA = "0x1810B2C90")]
		private void _LoadFragment(Act29SideData actData, string formId)
		{
		}

		// Token: 0x0601834E RID: 99150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601834E")]
		[Address(RVA = "0x10B30F0", Offset = "0x10B1CF0", VA = "0x1810B30F0")]
		public TuningCommonCardModel()
		{
		}

		// Token: 0x0401D795 RID: 120725
		[Token(Token = "0x401D795")]
		[FieldOffset(Offset = "0x10")]
		private string m_productTypeBasePicId;

		// Token: 0x0401D796 RID: 120726
		[Token(Token = "0x401D796")]
		[FieldOffset(Offset = "0x18")]
		private string m_orcheIconId;

		// Token: 0x0401D797 RID: 120727
		[Token(Token = "0x401D797")]
		[FieldOffset(Offset = "0x20")]
		private List<string> m_fragmentIconIdList;

		// Token: 0x0401D798 RID: 120728
		[Token(Token = "0x401D798")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedProductTypeId;

		// Token: 0x0401D799 RID: 120729
		[Token(Token = "0x401D799")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedOrcheId;

		// Token: 0x0401D79A RID: 120730
		[Token(Token = "0x401D79A")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedFormId;

		// Token: 0x0401D79B RID: 120731
		[Token(Token = "0x401D79B")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isChanged;

		// Token: 0x0401D79C RID: 120732
		[Token(Token = "0x401D79C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_productTypeBasePicId;

		// Token: 0x0401D79D RID: 120733
		[Token(Token = "0x401D79D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_orcheIconId;

		// Token: 0x0401D79E RID: 120734
		[Token(Token = "0x401D79E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_fragmentIconIdList;

		// Token: 0x0401D79F RID: 120735
		[Token(Token = "0x401D79F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isChanged;

		// Token: 0x0401D7A0 RID: 120736
		[Token(Token = "0x401D7A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_productTypeId;

		// Token: 0x0401D7A1 RID: 120737
		[Token(Token = "0x401D7A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_orcheId;

		// Token: 0x0401D7A2 RID: 120738
		[Token(Token = "0x401D7A2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_formId;

		// Token: 0x0401D7A3 RID: 120739
		[Token(Token = "0x401D7A3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D7A4 RID: 120740
		[Token(Token = "0x401D7A4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIsChanged;

		// Token: 0x0401D7A5 RID: 120741
		[Token(Token = "0x401D7A5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearData;

		// Token: 0x0401D7A6 RID: 120742
		[Token(Token = "0x401D7A6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadProductType;

		// Token: 0x0401D7A7 RID: 120743
		[Token(Token = "0x401D7A7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadOrche;

		// Token: 0x0401D7A8 RID: 120744
		[Token(Token = "0x401D7A8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadFragment;

		// Token: 0x0401D7A9 RID: 120745
		[Token(Token = "0x401D7A9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
