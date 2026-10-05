using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F43 RID: 16195
	[Token(Token = "0x2003F43")]
	public class SiracusaOperaState : PopupFadeState
	{
		// Token: 0x06019258 RID: 103000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019258")]
		[Address(RVA = "0x11DE320", Offset = "0x11DCF20", VA = "0x1811DE320", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019259 RID: 103001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019259")]
		[Address(RVA = "0x11DE380", Offset = "0x11DCF80", VA = "0x1811DE380", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601925A RID: 103002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601925A")]
		[Address(RVA = "0x11DE470", Offset = "0x11DD070", VA = "0x1811DE470", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601925B RID: 103003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601925B")]
		[Address(RVA = "0x11DE6E0", Offset = "0x11DD2E0", VA = "0x1811DE6E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601925C RID: 103004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601925C")]
		[Address(RVA = "0x11DE580", Offset = "0x11DD180", VA = "0x1811DE580")]
		public void OnSelectFrame(int index)
		{
		}

		// Token: 0x0601925D RID: 103005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601925D")]
		[Address(RVA = "0x11DE9D0", Offset = "0x11DD5D0", VA = "0x1811DE9D0")]
		public SiracusaOperaState()
		{
		}

		// Token: 0x0601925F RID: 103007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601925F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019260 RID: 103008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019260")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06019261 RID: 103009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019261")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401F27F RID: 127615
		[Token(Token = "0x401F27F")]
		[FieldOffset(Offset = "0x70")]
		private SiracusaOperaStateBean m_stateBean;

		// Token: 0x0401F280 RID: 127616
		[Token(Token = "0x401F280")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SiracusaOperaFrameHolder _holder;

		// Token: 0x0401F281 RID: 127617
		[Token(Token = "0x401F281")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SiracusaOperaFavorView _favorView;

		// Token: 0x0401F282 RID: 127618
		[Token(Token = "0x401F282")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F283 RID: 127619
		[Token(Token = "0x401F283")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F284 RID: 127620
		[Token(Token = "0x401F284")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401F285 RID: 127621
		[Token(Token = "0x401F285")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401F286 RID: 127622
		[Token(Token = "0x401F286")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSelectFrame;

		// Token: 0x0401F287 RID: 127623
		[Token(Token = "0x401F287")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
