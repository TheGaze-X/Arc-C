using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x0200187C RID: 6268
	[Token(Token = "0x200187C")]
	public class DIYRoomModifierMemento : IDIYRoomModifierManager, IDIYRoomModifierProvider
	{
		// Token: 0x06009EB0 RID: 40624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB0")]
		[Address(RVA = "0x318F580", Offset = "0x318E180", VA = "0x18318F580")]
		public void BuildFromModifierManager(IDIYRoomModifierManager mgr)
		{
		}

		// Token: 0x06009EB1 RID: 40625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB1")]
		[Address(RVA = "0x318FCE0", Offset = "0x318E8E0", VA = "0x18318FCE0")]
		public void SaveToModifierManager(IDIYRoomModifierManager mgr)
		{
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB2")]
		[Address(RVA = "0x318F950", Offset = "0x318E550", VA = "0x18318F950", Slot = "7")]
		public void QueryData(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action)
		{
		}

		// Token: 0x06009EB3 RID: 40627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB3")]
		[Address(RVA = "0x318FA40", Offset = "0x318E640", VA = "0x18318FA40", Slot = "8")]
		public void QueryDatas(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action)
		{
		}

		// Token: 0x06009EB4 RID: 40628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB4")]
		[Address(RVA = "0x318FB30", Offset = "0x318E730", VA = "0x18318FB30", Slot = "9")]
		public void RegisterListener(IDIYRoomModifierProviderListener listener)
		{
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB5")]
		[Address(RVA = "0x318FF90", Offset = "0x318EB90", VA = "0x18318FF90", Slot = "10")]
		public void UnregisterListener(IDIYRoomModifierProviderListener listener)
		{
		}

		// Token: 0x06009EB6 RID: 40630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB6")]
		[Address(RVA = "0x318F450", Offset = "0x318E050", VA = "0x18318F450", Slot = "4")]
		public void AddDIYRoomModifier(DIYRoomModifier modifier)
		{
		}

		// Token: 0x06009EB7 RID: 40631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB7")]
		[Address(RVA = "0x318FBB0", Offset = "0x318E7B0", VA = "0x18318FBB0", Slot = "5")]
		public void RemoveDIYRoomModifier(DIYRoomModifier modifier)
		{
		}

		// Token: 0x06009EB8 RID: 40632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB8")]
		[Address(RVA = "0x318F7C0", Offset = "0x318E3C0", VA = "0x18318F7C0", Slot = "6")]
		public void ClearDIYRoomModifier()
		{
		}

		// Token: 0x06009EB9 RID: 40633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB9")]
		[Address(RVA = "0x3190010", Offset = "0x318EC10", VA = "0x183190010")]
		public DIYRoomModifierMemento()
		{
		}

		// Token: 0x0400957C RID: 38268
		[Token(Token = "0x400957C")]
		[FieldOffset(Offset = "0x10")]
		private List<IDIYRoomModifierProviderListener> m_listeners;

		// Token: 0x0400957D RID: 38269
		[Token(Token = "0x400957D")]
		[FieldOffset(Offset = "0x18")]
		private List<DIYRoomModifier> m_modifiers;
	}
}
