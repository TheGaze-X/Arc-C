using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028AD RID: 10413
	[Token(Token = "0x20028AD")]
	public class BuffDuringSkill : BasicSkill.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x0601150E RID: 70926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601150E")]
		[Address(RVA = "0x91D990", Offset = "0x91C590", VA = "0x18091D990", Slot = "9")]
		public override void OnSkillStart()
		{
		}

		// Token: 0x0601150F RID: 70927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601150F")]
		[Address(RVA = "0x91D920", Offset = "0x91C520", VA = "0x18091D920", Slot = "10")]
		public override void OnSkillEnd()
		{
		}

		// Token: 0x06011510 RID: 70928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011510")]
		[Address(RVA = "0x91D8B0", Offset = "0x91C4B0", VA = "0x18091D8B0", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011511 RID: 70929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011511")]
		[Address(RVA = "0x91D820", Offset = "0x91C420", VA = "0x18091D820", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06011512 RID: 70930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011512")]
		[Address(RVA = "0x91DB10", Offset = "0x91C710", VA = "0x18091DB10")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x06011513 RID: 70931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011513")]
		[Address(RVA = "0x91DC00", Offset = "0x91C800", VA = "0x18091DC00")]
		public BuffDuringSkill()
		{
		}

		// Token: 0x06011514 RID: 70932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011514")]
		[Address(RVA = "0x91D780", Offset = "0x91C380", VA = "0x18091D780")]
		private void <>xLuaBaseProxy_OnSkillStart()
		{
		}

		// Token: 0x06011515 RID: 70933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011515")]
		[Address(RVA = "0x91D770", Offset = "0x91C370", VA = "0x18091D770")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x0401358A RID: 79242
		[Token(Token = "0x401358A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x0401358B RID: 79243
		[Token(Token = "0x401358B")]
		[FieldOffset(Offset = "0x28")]
		private List<uint> m_buffUid;

		// Token: 0x0401358C RID: 79244
		[Token(Token = "0x401358C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSkillStart;

		// Token: 0x0401358D RID: 79245
		[Token(Token = "0x401358D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x0401358E RID: 79246
		[Token(Token = "0x401358E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401358F RID: 79247
		[Token(Token = "0x401358F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04013590 RID: 79248
		[Token(Token = "0x4013590")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearBuffs;

		// Token: 0x04013591 RID: 79249
		[Token(Token = "0x4013591")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
