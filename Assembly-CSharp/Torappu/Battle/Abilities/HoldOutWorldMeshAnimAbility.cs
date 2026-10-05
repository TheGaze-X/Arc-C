using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A92 RID: 10898
	[Token(Token = "0x2002A92")]
	public class HoldOutWorldMeshAnimAbility : TriggablePassiveAbility
	{
		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x06012172 RID: 74098 RVA: 0x0006EBC8 File Offset: 0x0006CDC8
		[Token(Token = "0x170027B5")]
		private bool valid
		{
			[Token(Token = "0x6012172")]
			[Address(RVA = "0xA23860", Offset = "0xA22460", VA = "0x180A23860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x06012173 RID: 74099 RVA: 0x0006EBE0 File Offset: 0x0006CDE0
		// (set) Token: 0x06012174 RID: 74100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170027B6")]
		public Color color
		{
			[Token(Token = "0x6012173")]
			[Address(RVA = "0xA237C0", Offset = "0xA223C0", VA = "0x180A237C0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6012174")]
			[Address(RVA = "0xA238F0", Offset = "0xA224F0", VA = "0x180A238F0")]
			set
			{
			}
		}

		// Token: 0x06012175 RID: 74101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012175")]
		[Address(RVA = "0xA22240", Offset = "0xA20E40", VA = "0x180A22240", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012176 RID: 74102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012176")]
		[Address(RVA = "0xA223D0", Offset = "0xA20FD0", VA = "0x180A223D0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012177 RID: 74103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012177")]
		[Address(RVA = "0xA22D80", Offset = "0xA21980", VA = "0x180A22D80")]
		private void _HoldOutWorldMeshAnim()
		{
		}

		// Token: 0x06012178 RID: 74104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012178")]
		[Address(RVA = "0xA23650", Offset = "0xA22250", VA = "0x180A23650")]
		private void _ReleaseOutWorldMeshAnim()
		{
		}

		// Token: 0x06012179 RID: 74105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012179")]
		[Address(RVA = "0xA23270", Offset = "0xA21E70", VA = "0x180A23270")]
		private void _OnTakeDamage(object arg)
		{
		}

		// Token: 0x0601217A RID: 74106 RVA: 0x0006EBF8 File Offset: 0x0006CDF8
		[Token(Token = "0x601217A")]
		[Address(RVA = "0xA220C0", Offset = "0xA20CC0", VA = "0x180A220C0", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x0601217B RID: 74107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601217B")]
		[Address(RVA = "0xA23160", Offset = "0xA21D60", VA = "0x180A23160")]
		private void _OnSkillStart()
		{
		}

		// Token: 0x0601217C RID: 74108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601217C")]
		[Address(RVA = "0xA23050", Offset = "0xA21C50", VA = "0x180A23050")]
		private void _OnDeath(object arg)
		{
		}

		// Token: 0x0601217D RID: 74109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601217D")]
		[Address(RVA = "0xA22B40", Offset = "0xA21740", VA = "0x180A22B40")]
		private void _CreateEffects(HoldOutWorldMeshAnimAbility.TriggerType trigger)
		{
		}

		// Token: 0x0601217E RID: 74110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601217E")]
		[Address(RVA = "0xA23700", Offset = "0xA22300", VA = "0x180A23700")]
		public HoldOutWorldMeshAnimAbility()
		{
		}

		// Token: 0x06012184 RID: 74116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012184")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012185 RID: 74117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012185")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012186 RID: 74118 RVA: 0x0006EC10 File Offset: 0x0006CE10
		[Token(Token = "0x6012186")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0401479B RID: 83867
		[Token(Token = "0x401479B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private string _meshAnimName;

		// Token: 0x0401479C RID: 83868
		[Token(Token = "0x401479C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<HoldOutWorldMeshAnimAbility.DictionaryEntry> _meshAnimEffectList;

		// Token: 0x0401479D RID: 83869
		[Token(Token = "0x401479D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Dictionary<HoldOutWorldMeshAnimAbility.TriggerType, MapEffectData[]> m_meshAnimEffect;

		// Token: 0x0401479E RID: 83870
		[Token(Token = "0x401479E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Material m_material;

		// Token: 0x0401479F RID: 83871
		[Token(Token = "0x401479F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool lockColor;

		// Token: 0x040147A0 RID: 83872
		[Token(Token = "0x40147A0")]
		private const string SHADER_UNIFORM_KEY = "_DissolveClip";

		// Token: 0x040147A1 RID: 83873
		[Token(Token = "0x40147A1")]
		private const string SHADER_COLOR_KEY = "_Color";

		// Token: 0x040147A2 RID: 83874
		[Token(Token = "0x40147A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_valid;

		// Token: 0x040147A3 RID: 83875
		[Token(Token = "0x40147A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x040147A4 RID: 83876
		[Token(Token = "0x40147A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x040147A5 RID: 83877
		[Token(Token = "0x40147A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040147A6 RID: 83878
		[Token(Token = "0x40147A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040147A7 RID: 83879
		[Token(Token = "0x40147A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HoldOutWorldMeshAnim;

		// Token: 0x040147A8 RID: 83880
		[Token(Token = "0x40147A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ReleaseOutWorldMeshAnim;

		// Token: 0x040147A9 RID: 83881
		[Token(Token = "0x40147A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnTakeDamage;

		// Token: 0x040147AA RID: 83882
		[Token(Token = "0x40147AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x040147AB RID: 83883
		[Token(Token = "0x40147AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSkillStart;

		// Token: 0x040147AC RID: 83884
		[Token(Token = "0x40147AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnDeath;

		// Token: 0x040147AD RID: 83885
		[Token(Token = "0x40147AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CreateEffects;

		// Token: 0x040147AE RID: 83886
		[Token(Token = "0x40147AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A93 RID: 10899
		[Token(Token = "0x2002A93")]
		private enum TriggerType
		{
			// Token: 0x040147B0 RID: 83888
			[Token(Token = "0x40147B0")]
			None,
			// Token: 0x040147B1 RID: 83889
			[Token(Token = "0x40147B1")]
			ON_TAKE_DAMAGE,
			// Token: 0x040147B2 RID: 83890
			[Token(Token = "0x40147B2")]
			REACH_EXIT,
			// Token: 0x040147B3 RID: 83891
			[Token(Token = "0x40147B3")]
			ON_DEATH
		}

		// Token: 0x02002A94 RID: 10900
		[Token(Token = "0x2002A94")]
		[Serializable]
		private struct DictionaryEntry
		{
			// Token: 0x040147B4 RID: 83892
			[Token(Token = "0x40147B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HoldOutWorldMeshAnimAbility.TriggerType key;

			// Token: 0x040147B5 RID: 83893
			[Token(Token = "0x40147B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MapEffectData[] value;
		}
	}
}
