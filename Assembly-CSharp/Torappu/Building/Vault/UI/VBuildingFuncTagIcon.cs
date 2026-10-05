using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A87 RID: 6791
	[Token(Token = "0x2001A87")]
	public class VBuildingFuncTagIcon : VOUIPanel
	{
		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x0600AB3A RID: 43834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001438")]
		private ILODHolder lodHolder
		{
			[Token(Token = "0x600AB3A")]
			[Address(RVA = "0x3253340", Offset = "0x3251F40", VA = "0x183253340")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x0600AB3B RID: 43835 RVA: 0x00042360 File Offset: 0x00040560
		[Token(Token = "0x17001439")]
		private bool lodVisible
		{
			[Token(Token = "0x600AB3B")]
			[Address(RVA = "0x32533A0", Offset = "0x3251FA0", VA = "0x1832533A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x00042378 File Offset: 0x00040578
		[Token(Token = "0x600AB3C")]
		[Address(RVA = "0x3252A50", Offset = "0x3251650", VA = "0x183252A50", Slot = "4")]
		public override bool MatchObject(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB3D")]
		[Address(RVA = "0x3252C20", Offset = "0x3251820", VA = "0x183252C20", Slot = "6")]
		protected override void OnRoomObjectBinded(VRoom.Object roomObj)
		{
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB3E")]
		[Address(RVA = "0x3252DA0", Offset = "0x32519A0", VA = "0x183252DA0", Slot = "7")]
		protected override void OnRoomObjectStatusChanged()
		{
		}

		// Token: 0x0600AB3F RID: 43839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB3F")]
		[Address(RVA = "0x3252F60", Offset = "0x3251B60", VA = "0x183252F60", Slot = "9")]
		protected override void UpdateRender()
		{
		}

		// Token: 0x0600AB40 RID: 43840 RVA: 0x00042390 File Offset: 0x00040590
		[Token(Token = "0x600AB40")]
		[Address(RVA = "0x32530D0", Offset = "0x3251CD0", VA = "0x1832530D0")]
		private bool _CheckIfIconVisible()
		{
			return default(bool);
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB41")]
		[Address(RVA = "0x3253270", Offset = "0x3251E70", VA = "0x183253270")]
		public VBuildingFuncTagIcon()
		{
		}

		// Token: 0x0400A386 RID: 41862
		[Token(Token = "0x400A386")]
		private const float VISIBLE_HIGHT_THRESHOLD = 0.7f;

		// Token: 0x0400A387 RID: 41863
		[Token(Token = "0x400A387")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbstractVFuncTagSubItem[] _subItems;

		// Token: 0x0400A388 RID: 41864
		[Token(Token = "0x400A388")]
		[FieldOffset(Offset = "0x30")]
		private BuildingCharModel m_charModel;

		// Token: 0x0400A389 RID: 41865
		[Token(Token = "0x400A389")]
		[FieldOffset(Offset = "0xA8")]
		private ILODHolder m_lodHolder;
	}
}
