using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006663 RID: 26211
	[Token(Token = "0x2006663")]
	public class HandBookPage : StateEnginePage
	{
		// Token: 0x17005933 RID: 22835
		// (get) Token: 0x06025A35 RID: 154165 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025A36 RID: 154166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005933")]
		public HandBookJumpParam jumpParam
		{
			[Token(Token = "0x6025A35")]
			[Address(RVA = "0x209D120", Offset = "0x209BD20", VA = "0x18209D120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025A36")]
			[Address(RVA = "0x209D180", Offset = "0x209BD80", VA = "0x18209D180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005934 RID: 22836
		// (get) Token: 0x06025A37 RID: 154167 RVA: 0x000C89D0 File Offset: 0x000C6BD0
		[Token(Token = "0x17005934")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x6025A37")]
			[Address(RVA = "0x209D0C0", Offset = "0x209BCC0", VA = "0x18209D0C0", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x06025A38 RID: 154168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A38")]
		[Address(RVA = "0x209CC30", Offset = "0x209B830", VA = "0x18209CC30")]
		public void SetTopMenuActive(bool activeFlag)
		{
		}

		// Token: 0x06025A39 RID: 154169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A39")]
		[Address(RVA = "0x209CCC0", Offset = "0x209B8C0", VA = "0x18209CCC0")]
		public void SetTranObjectActive(bool activeFlag)
		{
		}

		// Token: 0x06025A3A RID: 154170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A3A")]
		[Address(RVA = "0x209CFA0", Offset = "0x209BBA0", VA = "0x18209CFA0")]
		private void _ReturnPage()
		{
		}

		// Token: 0x06025A3B RID: 154171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A3B")]
		[Address(RVA = "0x209CA80", Offset = "0x209B680", VA = "0x18209CA80", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06025A3C RID: 154172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A3C")]
		[Address(RVA = "0x209C830", Offset = "0x209B430", VA = "0x18209C830")]
		public static void HideTopMenu()
		{
		}

		// Token: 0x06025A3D RID: 154173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A3D")]
		[Address(RVA = "0x209CD40", Offset = "0x209B940", VA = "0x18209CD40")]
		public static void ShowTopMenu()
		{
		}

		// Token: 0x06025A3E RID: 154174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A3E")]
		[Address(RVA = "0x209C9D0", Offset = "0x209B5D0", VA = "0x18209C9D0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06025A3F RID: 154175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A3F")]
		[Address(RVA = "0x209C680", Offset = "0x209B280", VA = "0x18209C680", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x06025A40 RID: 154176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A40")]
		[Address(RVA = "0x209D060", Offset = "0x209BC60", VA = "0x18209D060")]
		public HandBookPage()
		{
		}

		// Token: 0x06025A44 RID: 154180 RVA: 0x000C89E8 File Offset: 0x000C6BE8
		[Token(Token = "0x6025A44")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x06025A45 RID: 154181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A45")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06025A46 RID: 154182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A46")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x06025A47 RID: 154183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A47")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x04034DF3 RID: 216563
		[Token(Token = "0x4034DF3")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04034DF4 RID: 216564
		[Token(Token = "0x4034DF4")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _transObject;

		// Token: 0x04034DF6 RID: 216566
		[Token(Token = "0x4034DF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_jumpParam;

		// Token: 0x04034DF7 RID: 216567
		[Token(Token = "0x4034DF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_jumpParam;

		// Token: 0x04034DF8 RID: 216568
		[Token(Token = "0x4034DF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x04034DF9 RID: 216569
		[Token(Token = "0x4034DF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetTopMenuActive;

		// Token: 0x04034DFA RID: 216570
		[Token(Token = "0x4034DFA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetTranObjectActive;

		// Token: 0x04034DFB RID: 216571
		[Token(Token = "0x4034DFB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReturnPage;

		// Token: 0x04034DFC RID: 216572
		[Token(Token = "0x4034DFC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04034DFD RID: 216573
		[Token(Token = "0x4034DFD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideTopMenu;

		// Token: 0x04034DFE RID: 216574
		[Token(Token = "0x4034DFE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowTopMenu;

		// Token: 0x04034DFF RID: 216575
		[Token(Token = "0x4034DFF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04034E00 RID: 216576
		[Token(Token = "0x4034E00")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04034E01 RID: 216577
		[Token(Token = "0x4034E01")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
