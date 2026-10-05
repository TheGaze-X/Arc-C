using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.UI.StationSelect;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001BA9 RID: 7081
	[Token(Token = "0x2001BA9")]
	public class BuildingStationSelectPage : BuildingCommonPage
	{
		// Token: 0x0600B095 RID: 45205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B095")]
		[Address(RVA = "0x32A69E0", Offset = "0x32A55E0", VA = "0x1832A69E0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0600B096 RID: 45206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B096")]
		[Address(RVA = "0x32A6900", Offset = "0x32A5500", VA = "0x1832A6900", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isToStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0600B097 RID: 45207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B097")]
		[Address(RVA = "0x32A6AA0", Offset = "0x32A56A0", VA = "0x1832A6AA0")]
		public BuildingStationSelectPage()
		{
		}

		// Token: 0x0600B098 RID: 45208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B098")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0600B099 RID: 45209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B099")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0400AB08 RID: 43784
		[Token(Token = "0x400AB08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0400AB09 RID: 43785
		[Token(Token = "0x400AB09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x0400AB0A RID: 43786
		[Token(Token = "0x400AB0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BAA RID: 7082
		[Token(Token = "0x2001BAA")]
		public new struct Param
		{
			// Token: 0x170014EC RID: 5356
			// (get) Token: 0x0600B09A RID: 45210 RVA: 0x00043788 File Offset: 0x00041988
			[Token(Token = "0x170014EC")]
			public bool isEmpty
			{
				[Token(Token = "0x600B09A")]
				[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0400AB0B RID: 43787
			[Token(Token = "0x400AB0B")]
			[FieldOffset(Offset = "0x0")]
			public string slotId;

			// Token: 0x0400AB0C RID: 43788
			[Token(Token = "0x400AB0C")]
			[FieldOffset(Offset = "0x8")]
			public StationSelectStateBean.StationSelectStateBeanInputType inputType;

			// Token: 0x0400AB0D RID: 43789
			[Token(Token = "0x400AB0D")]
			[FieldOffset(Offset = "0x10")]
			public BuildingStationSelectState.IPlugin plugin;

			// Token: 0x0400AB0E RID: 43790
			[Token(Token = "0x400AB0E")]
			[FieldOffset(Offset = "0x18")]
			public int maxSelectCount;

			// Token: 0x0400AB0F RID: 43791
			[Token(Token = "0x400AB0F")]
			[FieldOffset(Offset = "0x20")]
			public List<int> selectedCharInstIds;

			// Token: 0x0400AB10 RID: 43792
			[Token(Token = "0x400AB10")]
			[FieldOffset(Offset = "0x28")]
			public string currRoomTarget;

			// Token: 0x0400AB11 RID: 43793
			[Token(Token = "0x400AB11")]
			[FieldOffset(Offset = "0x30")]
			public int index;

			// Token: 0x0400AB12 RID: 43794
			[Token(Token = "0x400AB12")]
			[FieldOffset(Offset = "0x34")]
			public int queueIndex;
		}
	}
}
