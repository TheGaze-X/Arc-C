using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003267 RID: 12903
	[Token(Token = "0x2003267")]
	public class SwitchableDirectionEffectAct45Side : Effect.Behaviour
	{
		// Token: 0x06014756 RID: 83798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014756")]
		[Address(RVA = "0xCB8490", Offset = "0xCB7090", VA = "0x180CB8490", Slot = "4")]
		public override void Init(Effect effect)
		{
		}

		// Token: 0x06014757 RID: 83799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014757")]
		[Address(RVA = "0xCB8710", Offset = "0xCB7310", VA = "0x180CB8710", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014758 RID: 83800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014758")]
		[Address(RVA = "0xCB8370", Offset = "0xCB6F70", VA = "0x180CB8370")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014759 RID: 83801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014759")]
		[Address(RVA = "0xCB85B0", Offset = "0xCB71B0", VA = "0x180CB85B0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601475A RID: 83802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601475A")]
		[Address(RVA = "0xCB8910", Offset = "0xCB7510", VA = "0x180CB8910")]
		private void Update()
		{
		}

		// Token: 0x0601475B RID: 83803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601475B")]
		[Address(RVA = "0xCB8980", Offset = "0xCB7580", VA = "0x180CB8980")]
		private void _UpdateFace()
		{
		}

		// Token: 0x0601475C RID: 83804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601475C")]
		[Address(RVA = "0xCB8EC0", Offset = "0xCB7AC0", VA = "0x180CB8EC0")]
		public SwitchableDirectionEffectAct45Side()
		{
		}

		// Token: 0x0601475D RID: 83805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601475D")]
		[Address(RVA = "0xC9CCD0", Offset = "0xC9B8D0", VA = "0x180C9CCD0")]
		private void <>xLuaBaseProxy_Init(Effect P0)
		{
		}

		// Token: 0x0601475E RID: 83806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601475E")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601475F RID: 83807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601475F")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040182CE RID: 99022
		[Token(Token = "0x40182CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _leftEffect;

		// Token: 0x040182CF RID: 99023
		[Token(Token = "0x40182CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _rightEffect;

		// Token: 0x040182D0 RID: 99024
		[Token(Token = "0x40182D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _upEffect;

		// Token: 0x040182D1 RID: 99025
		[Token(Token = "0x40182D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _downEffect;

		// Token: 0x040182D2 RID: 99026
		[Token(Token = "0x40182D2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _pointEffect;

		// Token: 0x040182D3 RID: 99027
		[Token(Token = "0x40182D3")]
		[FieldOffset(Offset = "0x48")]
		private ObjectPtr<Effect> m_playEffect;

		// Token: 0x040182D4 RID: 99028
		[Token(Token = "0x40182D4")]
		[FieldOffset(Offset = "0x58")]
		private ObjectPtr<Effect> m_pointEffect;

		// Token: 0x040182D5 RID: 99029
		[Token(Token = "0x40182D5")]
		[FieldOffset(Offset = "0x68")]
		private Act45SideManager m_manager;

		// Token: 0x040182D6 RID: 99030
		[Token(Token = "0x40182D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040182D7 RID: 99031
		[Token(Token = "0x40182D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040182D8 RID: 99032
		[Token(Token = "0x40182D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040182D9 RID: 99033
		[Token(Token = "0x40182D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040182DA RID: 99034
		[Token(Token = "0x40182DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040182DB RID: 99035
		[Token(Token = "0x40182DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateFace;

		// Token: 0x040182DC RID: 99036
		[Token(Token = "0x40182DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
