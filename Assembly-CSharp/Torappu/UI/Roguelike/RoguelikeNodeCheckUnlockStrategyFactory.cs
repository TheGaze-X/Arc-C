using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200523E RID: 21054
	[Token(Token = "0x200523E")]
	public class RoguelikeNodeCheckUnlockStrategyFactory : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F120 RID: 127264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F120")]
		[Address(RVA = "0x18DAC60", Offset = "0x18D9860", VA = "0x1818DAC60")]
		public void InitDefaultStrategies()
		{
		}

		// Token: 0x0601F121 RID: 127265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F121")]
		[Address(RVA = "0x18DAD20", Offset = "0x18D9920", VA = "0x1818DAD20")]
		public void LoadDynamicStrategies(List<ICheckNodeUnlockStrategy> dynamicStrategies)
		{
		}

		// Token: 0x0601F122 RID: 127266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F122")]
		[Address(RVA = "0x18DAE70", Offset = "0x18D9A70", VA = "0x1818DAE70")]
		public ICheckNodeUnlockStrategy SelectSuitableStrategy(string topicId, RoguelikeTopicDetail detail)
		{
			return null;
		}

		// Token: 0x0601F123 RID: 127267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F123")]
		private void _RegisterStrategy<T>() where T : ICheckNodeUnlockStrategy, new()
		{
		}

		// Token: 0x0601F124 RID: 127268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F124")]
		[Address(RVA = "0x18DB130", Offset = "0x18D9D30", VA = "0x1818DB130")]
		private void _RegisterDynamicStrategy(ICheckNodeUnlockStrategy instance, int priority)
		{
		}

		// Token: 0x0601F125 RID: 127269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F125")]
		[Address(RVA = "0x18DB2B0", Offset = "0x18D9EB0", VA = "0x1818DB2B0")]
		private void _RegisterInternal(ICheckNodeUnlockStrategy instance, int priority)
		{
		}

		// Token: 0x0601F126 RID: 127270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F126")]
		[Address(RVA = "0x18DAFB0", Offset = "0x18D9BB0", VA = "0x1818DAFB0")]
		private void _RefreshSort()
		{
		}

		// Token: 0x0601F127 RID: 127271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F127")]
		[Address(RVA = "0x18DB3F0", Offset = "0x18D9FF0", VA = "0x1818DB3F0")]
		public RoguelikeNodeCheckUnlockStrategyFactory()
		{
		}

		// Token: 0x04029AB6 RID: 170678
		[Token(Token = "0x4029AB6")]
		[FieldOffset(Offset = "0x18")]
		private List<RoguelikeNodeCheckUnlockStrategyFactory.StrategyWrapper> m_strategies;

		// Token: 0x04029AB7 RID: 170679
		[Token(Token = "0x4029AB7")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isDirty;

		// Token: 0x04029AB8 RID: 170680
		[Token(Token = "0x4029AB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitDefaultStrategies;

		// Token: 0x04029AB9 RID: 170681
		[Token(Token = "0x4029AB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDynamicStrategies;

		// Token: 0x04029ABA RID: 170682
		[Token(Token = "0x4029ABA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectSuitableStrategy;

		// Token: 0x04029ABB RID: 170683
		[Token(Token = "0x4029ABB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterStrategy;

		// Token: 0x04029ABC RID: 170684
		[Token(Token = "0x4029ABC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterDynamicStrategy;

		// Token: 0x04029ABD RID: 170685
		[Token(Token = "0x4029ABD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterInternal;

		// Token: 0x04029ABE RID: 170686
		[Token(Token = "0x4029ABE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshSort;

		// Token: 0x04029ABF RID: 170687
		[Token(Token = "0x4029ABF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200523F RID: 21055
		[Token(Token = "0x200523F")]
		private struct StrategyWrapper
		{
			// Token: 0x04029AC0 RID: 170688
			[Token(Token = "0x4029AC0")]
			[FieldOffset(Offset = "0x0")]
			public ICheckNodeUnlockStrategy instance;

			// Token: 0x04029AC1 RID: 170689
			[Token(Token = "0x4029AC1")]
			[FieldOffset(Offset = "0x8")]
			public int cachedPriority;
		}
	}
}
