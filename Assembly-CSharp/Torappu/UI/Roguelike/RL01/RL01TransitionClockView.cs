using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057C5 RID: 22469
	[Token(Token = "0x20057C5")]
	public class RL01TransitionClockView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020DD5 RID: 134613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DD5")]
		[Address(RVA = "0x1B2F500", Offset = "0x1B2E100", VA = "0x181B2F500")]
		public Tween PlayAnim()
		{
			return null;
		}

		// Token: 0x06020DD6 RID: 134614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DD6")]
		[Address(RVA = "0x1B2F9D0", Offset = "0x1B2E5D0", VA = "0x181B2F9D0")]
		public void Render(RoguelikeGameZoneData zoneData)
		{
		}

		// Token: 0x06020DD7 RID: 134615 RVA: 0x000B79A8 File Offset: 0x000B5BA8
		[Token(Token = "0x6020DD7")]
		[Address(RVA = "0x1B2FC80", Offset = "0x1B2E880", VA = "0x181B2FC80")]
		private static bool _GeneHourAndMinute(RoguelikeGameZoneData zoneData, out int hourRotation, out int minuteRotation)
		{
			return default(bool);
		}

		// Token: 0x06020DD8 RID: 134616 RVA: 0x000B79C0 File Offset: 0x000B5BC0
		[Token(Token = "0x6020DD8")]
		[Address(RVA = "0x1B2FE20", Offset = "0x1B2EA20", VA = "0x181B2FE20")]
		private static int _GetRotationZ(int target, int total)
		{
			return 0;
		}

		// Token: 0x06020DD9 RID: 134617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DD9")]
		[Address(RVA = "0x1B2FEB0", Offset = "0x1B2EAB0", VA = "0x181B2FEB0")]
		public RL01TransitionClockView()
		{
		}

		// Token: 0x0402CA87 RID: 182919
		[Token(Token = "0x402CA87")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgHourHand;

		// Token: 0x0402CA88 RID: 182920
		[Token(Token = "0x402CA88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgMinuteHand;

		// Token: 0x0402CA89 RID: 182921
		[Token(Token = "0x402CA89")]
		[FieldOffset(Offset = "0x28")]
		private int m_hourRotation;

		// Token: 0x0402CA8A RID: 182922
		[Token(Token = "0x402CA8A")]
		[FieldOffset(Offset = "0x2C")]
		private int m_minuteRotation;

		// Token: 0x0402CA8B RID: 182923
		[Token(Token = "0x402CA8B")]
		private const float DURATION_PARAM = 0.8f;

		// Token: 0x0402CA8C RID: 182924
		[Token(Token = "0x402CA8C")]
		private const float DURATION_PARAM_2 = 1.8f;

		// Token: 0x0402CA8D RID: 182925
		[Token(Token = "0x402CA8D")]
		private const int FRAME_DURATION = 150;

		// Token: 0x0402CA8E RID: 182926
		[Token(Token = "0x402CA8E")]
		[FieldOffset(Offset = "0x30")]
		private bool m_showClockMove;

		// Token: 0x0402CA8F RID: 182927
		[Token(Token = "0x402CA8F")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_timeRotationTween;

		// Token: 0x0402CA90 RID: 182928
		[Token(Token = "0x402CA90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x0402CA91 RID: 182929
		[Token(Token = "0x402CA91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CA92 RID: 182930
		[Token(Token = "0x402CA92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GeneHourAndMinute;

		// Token: 0x0402CA93 RID: 182931
		[Token(Token = "0x402CA93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetRotationZ;

		// Token: 0x0402CA94 RID: 182932
		[Token(Token = "0x402CA94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
