using System;
using Il2CppDummyDll;
using Torappu.Building.UI;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001901 RID: 6401
	[Token(Token = "0x2001901")]
	public class MockDIYFeatureComponents : MonoBehaviour, IDIYFeatureComponents
	{
		// Token: 0x0600A146 RID: 41286 RVA: 0x0003ED60 File Offset: 0x0003CF60
		[Token(Token = "0x600A146")]
		[Address(RVA = "0x31CB8D0", Offset = "0x31CA4D0", VA = "0x1831CB8D0", Slot = "4")]
		public bool Init()
		{
			return default(bool);
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x0600A147 RID: 41287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001279")]
		public IFurnitureManager furnitureManager
		{
			[Token(Token = "0x600A147")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x0600A148 RID: 41288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127A")]
		public IDIYRoomModifierManager modifierManager
		{
			[Token(Token = "0x600A148")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x0600A149 RID: 41289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127B")]
		public IDIYRoomInfoProvider roomInfoManager
		{
			[Token(Token = "0x600A149")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x0600A14A RID: 41290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127C")]
		public IDIYPresetManager presetManager
		{
			[Token(Token = "0x600A14A")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x0600A14B RID: 41291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127D")]
		public IDIYShop shop
		{
			[Token(Token = "0x600A14B")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x0600A14C RID: 41292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127E")]
		public IFurnitureStorage storage
		{
			[Token(Token = "0x600A14C")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x0600A14D RID: 41293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127F")]
		public IFurnitureSaver saver
		{
			[Token(Token = "0x600A14D")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x0600A14E RID: 41294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001280")]
		public IFurnitureTypeDB furnitureTypeDB
		{
			[Token(Token = "0x600A14E")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x0600A14F RID: 41295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001281")]
		public IFurnitureDataProvider furnitureDataProvider
		{
			[Token(Token = "0x600A14F")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x0600A150 RID: 41296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001282")]
		public IDIYRoomModifierDataProvider modifierDataProvider
		{
			[Token(Token = "0x600A150")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x0600A151 RID: 41297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001283")]
		public IFurnitureGroupDataProvider furnitureGroupDatabase
		{
			[Token(Token = "0x600A151")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A152 RID: 41298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A152")]
		[Address(RVA = "0x31CBBA0", Offset = "0x31CA7A0", VA = "0x1831CBBA0")]
		public MockDIYFeatureComponents()
		{
		}

		// Token: 0x0400978D RID: 38797
		[Token(Token = "0x400978D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MockFurnitureFromTableManager _furnitureManager;

		// Token: 0x0400978E RID: 38798
		[Token(Token = "0x400978E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MockDIYRoomModifierManager _roomModifierManager;

		// Token: 0x0400978F RID: 38799
		[Token(Token = "0x400978F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MockDIYRoomInfoManager _roomInfoManager;

		// Token: 0x04009790 RID: 38800
		[Token(Token = "0x4009790")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MockDIYPresetManager _presetManager;

		// Token: 0x04009791 RID: 38801
		[Token(Token = "0x4009791")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MockDIYShop _diyShop;

		// Token: 0x04009792 RID: 38802
		[Token(Token = "0x4009792")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MockFurnitureStorage _furnitureStorage;

		// Token: 0x04009793 RID: 38803
		[Token(Token = "0x4009793")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MockFurnitureSaver _furnitureSaver;

		// Token: 0x04009794 RID: 38804
		[Token(Token = "0x4009794")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MockFurnitureGroupDB _furnitureGroupDatabase;

		// Token: 0x04009795 RID: 38805
		[Token(Token = "0x4009795")]
		[FieldOffset(Offset = "0x58")]
		private FurnitureDatabase m_furnitureDatabase;

		// Token: 0x04009796 RID: 38806
		[Token(Token = "0x4009796")]
		[FieldOffset(Offset = "0x60")]
		private DIYRoomModifierDatabase m_modifierDatabase;

		// Token: 0x04009797 RID: 38807
		[Token(Token = "0x4009797")]
		[FieldOffset(Offset = "0x68")]
		private FurnitureTypeDatabase m_furnitureTypeDatabase;

		// Token: 0x04009798 RID: 38808
		[Token(Token = "0x4009798")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;
	}
}
