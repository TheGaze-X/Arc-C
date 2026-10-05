using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003269 RID: 12905
	[Token(Token = "0x2003269")]
	public class SwitchableEffectByBuffCnt : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x0601476B RID: 83819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601476B")]
		[Address(RVA = "0xCB9E80", Offset = "0xCB8A80", VA = "0x180CB9E80", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x0601476C RID: 83820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601476C")]
		[Address(RVA = "0xCB9D60", Offset = "0xCB8960", VA = "0x180CB9D60", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601476D RID: 83821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601476D")]
		[Address(RVA = "0xCB9E10", Offset = "0xCB8A10", VA = "0x180CB9E10", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601476E RID: 83822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601476E")]
		[Address(RVA = "0xCB9F00", Offset = "0xCB8B00", VA = "0x180CB9F00")]
		private void Update()
		{
		}

		// Token: 0x0601476F RID: 83823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601476F")]
		[Address(RVA = "0xCBA0F0", Offset = "0xCB8CF0", VA = "0x180CBA0F0")]
		private void _UpdateEffectWithBuffCnt()
		{
		}

		// Token: 0x06014770 RID: 83824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014770")]
		[Address(RVA = "0xCB9FB0", Offset = "0xCB8BB0", VA = "0x180CB9FB0")]
		private void _FinishLastEffect()
		{
		}

		// Token: 0x06014771 RID: 83825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014771")]
		[Address(RVA = "0xCB9D00", Offset = "0xCB8900", VA = "0x180CB9D00", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x06014772 RID: 83826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014772")]
		[Address(RVA = "0xCBA350", Offset = "0xCB8F50", VA = "0x180CBA350")]
		public SwitchableEffectByBuffCnt()
		{
		}

		// Token: 0x06014773 RID: 83827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014773")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014774 RID: 83828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014774")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040182EF RID: 99055
		[Token(Token = "0x40182EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x040182F0 RID: 99056
		[Token(Token = "0x40182F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x040182F1 RID: 99057
		[Token(Token = "0x40182F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x040182F2 RID: 99058
		[Token(Token = "0x40182F2")]
		[FieldOffset(Offset = "0x34")]
		private int m_lastCnt;

		// Token: 0x040182F3 RID: 99059
		[Token(Token = "0x40182F3")]
		[FieldOffset(Offset = "0x38")]
		private float m_updateInterval;

		// Token: 0x040182F4 RID: 99060
		[Token(Token = "0x40182F4")]
		[FieldOffset(Offset = "0x40")]
		private ObjectPtr<Effect> m_lastEff;

		// Token: 0x040182F5 RID: 99061
		[Token(Token = "0x40182F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040182F6 RID: 99062
		[Token(Token = "0x40182F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040182F7 RID: 99063
		[Token(Token = "0x40182F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040182F8 RID: 99064
		[Token(Token = "0x40182F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040182F9 RID: 99065
		[Token(Token = "0x40182F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateEffectWithBuffCnt;

		// Token: 0x040182FA RID: 99066
		[Token(Token = "0x40182FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FinishLastEffect;

		// Token: 0x040182FB RID: 99067
		[Token(Token = "0x40182FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x040182FC RID: 99068
		[Token(Token = "0x40182FC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
