using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005163 RID: 20835
	[Token(Token = "0x2005163")]
	public class DeepSeaRPEndingZoneGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170047B2 RID: 18354
		// (get) Token: 0x0601EC8F RID: 126095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EC90 RID: 126096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047B2")]
		public Action<string> onZoneClicked
		{
			[Token(Token = "0x601EC8F")]
			[Address(RVA = "0x1868B60", Offset = "0x1867760", VA = "0x181868B60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EC90")]
			[Address(RVA = "0x1868BC0", Offset = "0x18677C0", VA = "0x181868BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601EC91 RID: 126097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC91")]
		[Address(RVA = "0x1868600", Offset = "0x1867200", VA = "0x181868600")]
		public void Render(List<DeepSeaRPZoneMapModel> zoneMapModelList, string selectedZoneId)
		{
		}

		// Token: 0x0601EC92 RID: 126098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC92")]
		[Address(RVA = "0x18689E0", Offset = "0x18675E0", VA = "0x1818689E0")]
		private void _EventOnZoneClick(string zoneId)
		{
		}

		// Token: 0x0601EC93 RID: 126099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC93")]
		[Address(RVA = "0x1868B00", Offset = "0x1867700", VA = "0x181868B00")]
		public DeepSeaRPEndingZoneGroupView()
		{
		}

		// Token: 0x0402945A RID: 169050
		[Token(Token = "0x402945A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _transContainer;

		// Token: 0x0402945B RID: 169051
		[Token(Token = "0x402945B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<DeepSeaRPEndingZoneView> _zoneViewList;

		// Token: 0x0402945C RID: 169052
		[Token(Token = "0x402945C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _wrapper;

		// Token: 0x0402945D RID: 169053
		[Token(Token = "0x402945D")]
		private const float CONTAINER_POS_ONE_BIG_ZONE = 131f;

		// Token: 0x0402945E RID: 169054
		[Token(Token = "0x402945E")]
		private const float CONTAINER_POS_TWO_BIG_ZONE = 171f;

		// Token: 0x0402945F RID: 169055
		[Token(Token = "0x402945F")]
		private const float CONTAINER_POS_THREE_BIG_ZONE = 231f;

		// Token: 0x04029460 RID: 169056
		[Token(Token = "0x4029460")]
		private const string FADE_IN_PARAM = "ending_detail_enter_anim";

		// Token: 0x04029462 RID: 169058
		[Token(Token = "0x4029462")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onZoneClicked;

		// Token: 0x04029463 RID: 169059
		[Token(Token = "0x4029463")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onZoneClicked;

		// Token: 0x04029464 RID: 169060
		[Token(Token = "0x4029464")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029465 RID: 169061
		[Token(Token = "0x4029465")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnZoneClick;

		// Token: 0x04029466 RID: 169062
		[Token(Token = "0x4029466")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
