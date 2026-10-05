using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x0200190F RID: 6415
	[Token(Token = "0x200190F")]
	public class MockDIYRoomModifierManager : MonoBehaviour, IDIYRoomModifierManager, IDIYRoomModifierProvider
	{
		// Token: 0x0600A193 RID: 41363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A193")]
		[Address(RVA = "0x31CD4F0", Offset = "0x31CC0F0", VA = "0x1831CD4F0")]
		public void Setup([Optional] IDIYRoomModifierDataProvider db)
		{
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A194")]
		[Address(RVA = "0x31CCEA0", Offset = "0x31CBAA0", VA = "0x1831CCEA0", Slot = "4")]
		public void AddDIYRoomModifier(DIYRoomModifier modifier)
		{
		}

		// Token: 0x0600A195 RID: 41365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A195")]
		[Address(RVA = "0x31CD3C0", Offset = "0x31CBFC0", VA = "0x1831CD3C0", Slot = "5")]
		public void RemoveDIYRoomModifier(DIYRoomModifier modifier)
		{
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A196")]
		[Address(RVA = "0x31CCFD0", Offset = "0x31CBBD0", VA = "0x1831CCFD0", Slot = "6")]
		public void ClearDIYRoomModifier()
		{
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A197")]
		[Address(RVA = "0x31CD160", Offset = "0x31CBD60", VA = "0x1831CD160", Slot = "7")]
		public void QueryData(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action)
		{
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A198")]
		[Address(RVA = "0x31CD250", Offset = "0x31CBE50", VA = "0x1831CD250", Slot = "8")]
		public void QueryDatas(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action)
		{
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A199")]
		[Address(RVA = "0x31CD340", Offset = "0x31CBF40", VA = "0x1831CD340", Slot = "9")]
		public void RegisterListener(IDIYRoomModifierProviderListener listener)
		{
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A19A")]
		[Address(RVA = "0x31CD6C0", Offset = "0x31CC2C0", VA = "0x1831CD6C0", Slot = "10")]
		public void UnregisterListener(IDIYRoomModifierProviderListener listener)
		{
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A19B")]
		[Address(RVA = "0x31CD740", Offset = "0x31CC340", VA = "0x1831CD740")]
		public MockDIYRoomModifierManager()
		{
		}

		// Token: 0x040097E1 RID: 38881
		[Token(Token = "0x40097E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MockDIYRoomModifierManager.MockDIYRoomModifierConfig[] _DIYRoomModifierConfigs;

		// Token: 0x040097E2 RID: 38882
		[Token(Token = "0x40097E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MockDIYRoomModifierDB _DIYRoomModifierDB;

		// Token: 0x040097E3 RID: 38883
		[Token(Token = "0x40097E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<IDIYRoomModifierProviderListener> m_listeners;

		// Token: 0x040097E4 RID: 38884
		[Token(Token = "0x40097E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<DIYRoomModifier> m_DIYRoomModifiers;

		// Token: 0x040097E5 RID: 38885
		[Token(Token = "0x40097E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IDIYRoomModifierDataProvider m_dataProvider;

		// Token: 0x02001910 RID: 6416
		[Token(Token = "0x2001910")]
		[Serializable]
		public class MockDIYRoomModifierConfig
		{
			// Token: 0x0600A19C RID: 41372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A19C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MockDIYRoomModifierConfig()
			{
			}

			// Token: 0x040097E6 RID: 38886
			[Token(Token = "0x40097E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040097E7 RID: 38887
			[Token(Token = "0x40097E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int roomIndex;
		}
	}
}
