using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003268 RID: 12904
	[Token(Token = "0x2003268")]
	public class SwitchableEffectByBlackboardValue : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x06014760 RID: 83808 RVA: 0x00086E68 File Offset: 0x00085068
		[Token(Token = "0x1700305F")]
		private ObjectPtr<Buff> holdBuff
		{
			[Token(Token = "0x6014760")]
			[Address(RVA = "0xCB9B80", Offset = "0xCB8780", VA = "0x180CB9B80")]
			get
			{
				return default(ObjectPtr<Buff>);
			}
		}

		// Token: 0x06014761 RID: 83809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014761")]
		[Address(RVA = "0xCB9100", Offset = "0xCB7D00", VA = "0x180CB9100", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014762 RID: 83810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014762")]
		[Address(RVA = "0xCB8FE0", Offset = "0xCB7BE0", VA = "0x180CB8FE0", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014763 RID: 83811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014763")]
		[Address(RVA = "0xCB9090", Offset = "0xCB7C90", VA = "0x180CB9090", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014764 RID: 83812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014764")]
		[Address(RVA = "0xCB9220", Offset = "0xCB7E20", VA = "0x180CB9220")]
		private void Update()
		{
		}

		// Token: 0x06014765 RID: 83813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014765")]
		[Address(RVA = "0xCB9500", Offset = "0xCB8100", VA = "0x180CB9500")]
		private void _UpdateEffect()
		{
		}

		// Token: 0x06014766 RID: 83814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014766")]
		[Address(RVA = "0xCB92D0", Offset = "0xCB7ED0", VA = "0x180CB92D0")]
		private void _FinishAllEffects()
		{
		}

		// Token: 0x06014767 RID: 83815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014767")]
		[Address(RVA = "0xCB8F80", Offset = "0xCB7B80", VA = "0x180CB8F80", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x06014768 RID: 83816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014768")]
		[Address(RVA = "0xCB9A90", Offset = "0xCB8690", VA = "0x180CB9A90")]
		public SwitchableEffectByBlackboardValue()
		{
		}

		// Token: 0x06014769 RID: 83817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014769")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601476A RID: 83818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601476A")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040182DD RID: 99037
		[Token(Token = "0x40182DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x040182DE RID: 99038
		[Token(Token = "0x40182DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _blackboardKey;

		// Token: 0x040182DF RID: 99039
		[Token(Token = "0x40182DF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x040182E0 RID: 99040
		[Token(Token = "0x40182E0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x040182E1 RID: 99041
		[Token(Token = "0x40182E1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _useFaceto;

		// Token: 0x040182E2 RID: 99042
		[Token(Token = "0x40182E2")]
		[FieldOffset(Offset = "0x40")]
		private int m_lastValue;

		// Token: 0x040182E3 RID: 99043
		[Token(Token = "0x40182E3")]
		[FieldOffset(Offset = "0x44")]
		private float m_updateInterval;

		// Token: 0x040182E4 RID: 99044
		[Token(Token = "0x40182E4")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<int, ObjectPtr<Effect>> m_cachedEffects;

		// Token: 0x040182E5 RID: 99045
		[Token(Token = "0x40182E5")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Buff> m_holdBuff;

		// Token: 0x040182E6 RID: 99046
		[Token(Token = "0x40182E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_holdBuff;

		// Token: 0x040182E7 RID: 99047
		[Token(Token = "0x40182E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040182E8 RID: 99048
		[Token(Token = "0x40182E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040182E9 RID: 99049
		[Token(Token = "0x40182E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040182EA RID: 99050
		[Token(Token = "0x40182EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040182EB RID: 99051
		[Token(Token = "0x40182EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateEffect;

		// Token: 0x040182EC RID: 99052
		[Token(Token = "0x40182EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FinishAllEffects;

		// Token: 0x040182ED RID: 99053
		[Token(Token = "0x40182ED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x040182EE RID: 99054
		[Token(Token = "0x40182EE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
