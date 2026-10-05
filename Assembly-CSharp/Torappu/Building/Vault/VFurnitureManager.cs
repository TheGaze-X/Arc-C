using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A3B RID: 6715
	[Token(Token = "0x2001A3B")]
	public class VFurnitureManager : IHotfixable
	{
		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x0600A85D RID: 43101 RVA: 0x000412F8 File Offset: 0x0003F4F8
		[Token(Token = "0x17001389")]
		public bool isEmpty
		{
			[Token(Token = "0x600A85D")]
			[Address(RVA = "0x32440B0", Offset = "0x3242CB0", VA = "0x1832440B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x0600A85E RID: 43102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700138A")]
		public List<VFurnitureBridge> furnitures
		{
			[Token(Token = "0x600A85E")]
			[Address(RVA = "0x3244040", Offset = "0x3242C40", VA = "0x183244040")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A85F RID: 43103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A85F")]
		[Address(RVA = "0x3243230", Offset = "0x3241E30", VA = "0x183243230")]
		public void Init(IList<VFurnitureBridge> furnitures)
		{
		}

		// Token: 0x0600A860 RID: 43104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A860")]
		[Address(RVA = "0x3242FF0", Offset = "0x3241BF0", VA = "0x183242FF0")]
		public void Add(VFurnitureBridge furniture)
		{
		}

		// Token: 0x0600A861 RID: 43105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A861")]
		[Address(RVA = "0x3243140", Offset = "0x3241D40", VA = "0x183243140")]
		public void ClearAll()
		{
		}

		// Token: 0x0600A862 RID: 43106 RVA: 0x00041310 File Offset: 0x0003F510
		[Token(Token = "0x600A862")]
		[Address(RVA = "0x3243C70", Offset = "0x3242870", VA = "0x183243C70")]
		public bool PickRandomSlot(VCharacter character, out VFurnitureBridge.InteractSlot slot, Func<VCharacter, VFurnitureBridge.InteractSlot, bool> validator)
		{
			return default(bool);
		}

		// Token: 0x0600A863 RID: 43107 RVA: 0x00041328 File Offset: 0x0003F528
		[Token(Token = "0x600A863")]
		[Address(RVA = "0x3243830", Offset = "0x3242430", VA = "0x183243830")]
		public bool PickRandomSlot(VCharacter character, out VFurnitureBridge.InteractSlot slot, Func<VCharacter, VFurnitureBridge.InteractSlot, bool> validator, IList<VFurnitureBridge.InteractSlot> slots)
		{
			return default(bool);
		}

		// Token: 0x0600A864 RID: 43108 RVA: 0x00041340 File Offset: 0x0003F540
		[Token(Token = "0x600A864")]
		[Address(RVA = "0x32434B0", Offset = "0x32420B0", VA = "0x1832434B0")]
		public bool PickRandomSlotWithWeight(VCharacter character, out VFurnitureBridge.InteractSlot slot, Func<VCharacter, VFurnitureBridge.InteractSlot, float> weightGetter)
		{
			return default(bool);
		}

		// Token: 0x0600A865 RID: 43109 RVA: 0x00041358 File Offset: 0x0003F558
		[Token(Token = "0x600A865")]
		[Address(RVA = "0x3243D30", Offset = "0x3242930", VA = "0x183243D30")]
		private bool _ValidSlot(VCharacter targetChar, VFurnitureBridge.InteractSlot slot)
		{
			return default(bool);
		}

		// Token: 0x0600A866 RID: 43110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A866")]
		[Address(RVA = "0x3243F20", Offset = "0x3242B20", VA = "0x183243F20")]
		public VFurnitureManager()
		{
		}

		// Token: 0x0400A09E RID: 41118
		[Token(Token = "0x400A09E")]
		[FieldOffset(Offset = "0x0")]
		private static List<VFurnitureBridge.InteractSlot> s_sharedSlotList;

		// Token: 0x0400A09F RID: 41119
		[Token(Token = "0x400A09F")]
		[FieldOffset(Offset = "0x10")]
		private List<VFurnitureBridge> m_furnitures;

		// Token: 0x0400A0A0 RID: 41120
		[Token(Token = "0x400A0A0")]
		[FieldOffset(Offset = "0x18")]
		private List<VFurnitureBridge.InteractSlot> m_slots;

		// Token: 0x0400A0A1 RID: 41121
		[Token(Token = "0x400A0A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0400A0A2 RID: 41122
		[Token(Token = "0x400A0A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_furnitures;

		// Token: 0x0400A0A3 RID: 41123
		[Token(Token = "0x400A0A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400A0A4 RID: 41124
		[Token(Token = "0x400A0A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Add;

		// Token: 0x0400A0A5 RID: 41125
		[Token(Token = "0x400A0A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClearAll;

		// Token: 0x0400A0A6 RID: 41126
		[Token(Token = "0x400A0A6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PickRandomSlot;

		// Token: 0x0400A0A7 RID: 41127
		[Token(Token = "0x400A0A7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_PickRandomSlot;

		// Token: 0x0400A0A8 RID: 41128
		[Token(Token = "0x400A0A8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PickRandomSlotWithWeight;

		// Token: 0x0400A0A9 RID: 41129
		[Token(Token = "0x400A0A9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ValidSlot;

		// Token: 0x0400A0AA RID: 41130
		[Token(Token = "0x400A0AA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
