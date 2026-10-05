using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006DA6 RID: 28070
	[Token(Token = "0x2006DA6")]
	public class ActivityCommonCheckinDotView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027FA0 RID: 163744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FA0")]
		[Address(RVA = "0x2336050", Offset = "0x2334C50", VA = "0x182336050")]
		public void RenderView(ActivityCommonCheckinDotView.DotViewConfigGroup configGroup, List<int> playerHistorys, Dictionary<int, DefaultCheckInData.CheckInDailyInfo> checkInList)
		{
		}

		// Token: 0x06027FA1 RID: 163745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FA1")]
		[Address(RVA = "0x2336AA0", Offset = "0x23356A0", VA = "0x182336AA0")]
		private void _RenderLines(ActivityCommonCheckinDotView.DotViewConfigGroup configGroup, int splitPos, int totalCount)
		{
		}

		// Token: 0x06027FA2 RID: 163746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FA2")]
		[Address(RVA = "0x2336670", Offset = "0x2335270", VA = "0x182336670")]
		private void _RenderDots(ActivityCommonCheckinDotView.DotViewConfigGroup configGroup, List<int> playerHistorys, Dictionary<int, DefaultCheckInData.CheckInDailyInfo> checkInList)
		{
		}

		// Token: 0x06027FA3 RID: 163747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FA3")]
		[Address(RVA = "0x2336300", Offset = "0x2334F00", VA = "0x182336300")]
		private void _InstLine(ActivityCommonCheckinDotView.DotViewConfigGroup configGroup, int cutPos, int totalCount)
		{
		}

		// Token: 0x06027FA4 RID: 163748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FA4")]
		[Address(RVA = "0x2336E90", Offset = "0x2335A90", VA = "0x182336E90")]
		private void _UpdateWhiteLineTransform(GameObject lineObject, int cutPos, int totalCount)
		{
		}

		// Token: 0x06027FA5 RID: 163749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FA5")]
		[Address(RVA = "0x2336BF0", Offset = "0x23357F0", VA = "0x182336BF0")]
		private void _UpdateGrayLineTransform(GameObject lineObject, int cutPos, int totalCount)
		{
		}

		// Token: 0x06027FA6 RID: 163750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FA6")]
		[Address(RVA = "0x2336D70", Offset = "0x2335970", VA = "0x182336D70")]
		private void _UpdateImagePos(ActivityCommonCheckinDotObj image, int pos, int totalCount)
		{
		}

		// Token: 0x06027FA7 RID: 163751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FA7")]
		[Address(RVA = "0x23365C0", Offset = "0x23351C0", VA = "0x1823365C0")]
		private void _OnDotClick(int index)
		{
		}

		// Token: 0x06027FA8 RID: 163752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FA8")]
		[Address(RVA = "0x2337000", Offset = "0x2335C00", VA = "0x182337000")]
		public ActivityCommonCheckinDotView()
		{
		}

		// Token: 0x04038A84 RID: 232068
		[Token(Token = "0x4038A84")]
		private const string LINE_NAME = "line";

		// Token: 0x04038A85 RID: 232069
		[Token(Token = "0x4038A85")]
		private const string DOT_NAME = "dot";

		// Token: 0x04038A86 RID: 232070
		[Token(Token = "0x4038A86")]
		private const int LINE_HEIGHT = 4;

		// Token: 0x04038A87 RID: 232071
		[Token(Token = "0x4038A87")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04038A88 RID: 232072
		[Token(Token = "0x4038A88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityCommonCheckinDotObj _dotObj;

		// Token: 0x04038A89 RID: 232073
		[Token(Token = "0x4038A89")]
		[FieldOffset(Offset = "0x28")]
		private int m_splitPos;

		// Token: 0x04038A8A RID: 232074
		[Token(Token = "0x4038A8A")]
		[FieldOffset(Offset = "0x2C")]
		private float m_width;

		// Token: 0x04038A8B RID: 232075
		[Token(Token = "0x4038A8B")]
		[FieldOffset(Offset = "0x30")]
		private List<ActivityCommonCheckinDotObj> m_dotList;

		// Token: 0x04038A8C RID: 232076
		[Token(Token = "0x4038A8C")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_whiteLine;

		// Token: 0x04038A8D RID: 232077
		[Token(Token = "0x4038A8D")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_grayLine;

		// Token: 0x04038A8E RID: 232078
		[Token(Token = "0x4038A8E")]
		[FieldOffset(Offset = "0x48")]
		private Action<int, int> m_onDotClick;

		// Token: 0x04038A8F RID: 232079
		[Token(Token = "0x4038A8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04038A90 RID: 232080
		[Token(Token = "0x4038A90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderLines;

		// Token: 0x04038A91 RID: 232081
		[Token(Token = "0x4038A91")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDots;

		// Token: 0x04038A92 RID: 232082
		[Token(Token = "0x4038A92")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InstLine;

		// Token: 0x04038A93 RID: 232083
		[Token(Token = "0x4038A93")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateWhiteLineTransform;

		// Token: 0x04038A94 RID: 232084
		[Token(Token = "0x4038A94")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateGrayLineTransform;

		// Token: 0x04038A95 RID: 232085
		[Token(Token = "0x4038A95")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateImagePos;

		// Token: 0x04038A96 RID: 232086
		[Token(Token = "0x4038A96")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnDotClick;

		// Token: 0x04038A97 RID: 232087
		[Token(Token = "0x4038A97")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DA7 RID: 28071
		[Token(Token = "0x2006DA7")]
		public class DotViewConfigGroup
		{
			// Token: 0x06027FA9 RID: 163753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027FA9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DotViewConfigGroup()
			{
			}

			// Token: 0x04038A98 RID: 232088
			[Token(Token = "0x4038A98")]
			[FieldOffset(Offset = "0x10")]
			public Sprite normalDot;

			// Token: 0x04038A99 RID: 232089
			[Token(Token = "0x4038A99")]
			[FieldOffset(Offset = "0x18")]
			public Sprite bigDot;

			// Token: 0x04038A9A RID: 232090
			[Token(Token = "0x4038A9A")]
			[FieldOffset(Offset = "0x20")]
			public Sprite acceptableDot;

			// Token: 0x04038A9B RID: 232091
			[Token(Token = "0x4038A9B")]
			[FieldOffset(Offset = "0x28")]
			public Color outlineColor;

			// Token: 0x04038A9C RID: 232092
			[Token(Token = "0x4038A9C")]
			[FieldOffset(Offset = "0x38")]
			public Color notGetColor;

			// Token: 0x04038A9D RID: 232093
			[Token(Token = "0x4038A9D")]
			[FieldOffset(Offset = "0x48")]
			public Action<int, int> onDotClick;
		}
	}
}
