using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x0200187A RID: 6266
	[Token(Token = "0x200187A")]
	public class DIYRoomModifierManager : IDIYRoomModifierManager, IDIYRoomModifierProvider
	{
		// Token: 0x06009E9F RID: 40607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E9F")]
		[Address(RVA = "0x17B51E0", Offset = "0x17B3DE0", VA = "0x1817B51E0")]
		public void SetDataDirty()
		{
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA0")]
		[Address(RVA = "0x318EED0", Offset = "0x318DAD0", VA = "0x18318EED0")]
		public void Setup(IDIYRoomModifierDataProvider db, bool ignoreRefresh = false)
		{
		}

		// Token: 0x06009EA1 RID: 40609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA1")]
		[Address(RVA = "0x318E7E0", Offset = "0x318D3E0", VA = "0x18318E7E0")]
		public void Refresh(PlayerBuildingRoom playerBuildingRoom)
		{
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA2")]
		[Address(RVA = "0x318EFF0", Offset = "0x318DBF0", VA = "0x18318EFF0")]
		private void _Refresh(string slotId, PlayerBuildingDIYSolution diySolution)
		{
		}

		// Token: 0x06009EA3 RID: 40611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA3")]
		[Address(RVA = "0x318E280", Offset = "0x318CE80", VA = "0x18318E280", Slot = "4")]
		public void AddDIYRoomModifier(DIYRoomModifier modifier)
		{
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA4")]
		[Address(RVA = "0x318EDA0", Offset = "0x318D9A0", VA = "0x18318EDA0", Slot = "5")]
		public void RemoveDIYRoomModifier(DIYRoomModifier modifier)
		{
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA5")]
		[Address(RVA = "0x318E3B0", Offset = "0x318CFB0", VA = "0x18318E3B0", Slot = "6")]
		public void ClearDIYRoomModifier()
		{
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA6")]
		[Address(RVA = "0x318E540", Offset = "0x318D140", VA = "0x18318E540", Slot = "7")]
		public void QueryData(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action)
		{
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA7")]
		[Address(RVA = "0x318E690", Offset = "0x318D290", VA = "0x18318E690", Slot = "8")]
		public void QueryDatas(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action)
		{
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA8")]
		[Address(RVA = "0x318ED20", Offset = "0x318D920", VA = "0x18318ED20", Slot = "9")]
		public void RegisterListener(IDIYRoomModifierProviderListener listener)
		{
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA9")]
		[Address(RVA = "0x318EF70", Offset = "0x318DB70", VA = "0x18318EF70", Slot = "10")]
		public void UnregisterListener(IDIYRoomModifierProviderListener listener)
		{
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EAA")]
		[Address(RVA = "0x318F380", Offset = "0x318DF80", VA = "0x18318F380")]
		public DIYRoomModifierManager()
		{
		}

		// Token: 0x04009575 RID: 38261
		[Token(Token = "0x4009575")]
		[FieldOffset(Offset = "0x10")]
		private List<IDIYRoomModifierProviderListener> m_listeners;

		// Token: 0x04009576 RID: 38262
		[Token(Token = "0x4009576")]
		[FieldOffset(Offset = "0x18")]
		private List<DIYRoomModifier> m_DIYRoomModifiers;

		// Token: 0x04009577 RID: 38263
		[Token(Token = "0x4009577")]
		[FieldOffset(Offset = "0x20")]
		private IDIYRoomModifierDataProvider m_dataProvider;

		// Token: 0x04009578 RID: 38264
		[Token(Token = "0x4009578")]
		[FieldOffset(Offset = "0x28")]
		private bool m_diyRoomModifierDataDirty;
	}
}
