using System;
using System.Collections.Generic;
using System.Reflection;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.Action;
using Torappu.UI;
using UnityEngine;
using XLua.CSObjectWrap;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000250 RID: 592
	[Token(Token = "0x2000250")]
	public class ObjectTranslator
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06003480 RID: 13440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000141")]
		private static ObjectTranslator.IniterAdderUnityEngineVector2 IniterAdderUnityEngineVector2_dumb_obj
		{
			[Token(Token = "0x6003480")]
			[Address(RVA = "0x3214690", Offset = "0x3213290", VA = "0x183214690")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x320E040", Offset = "0x320CC40", VA = "0x18320E040")]
		public void PushUnityEngineVector2(IntPtr L, Vector2 val)
		{
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x3207190", Offset = "0x3205D90", VA = "0x183207190")]
		public void Get(IntPtr L, int index, out Vector2 val)
		{
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003483")]
		[Address(RVA = "0x32114A0", Offset = "0x32100A0", VA = "0x1832114A0")]
		public void UpdateUnityEngineVector2(IntPtr L, int index, Vector2 val)
		{
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003484")]
		[Address(RVA = "0x320E1B0", Offset = "0x320CDB0", VA = "0x18320E1B0")]
		public void PushUnityEngineVector3(IntPtr L, Vector3 val)
		{
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003485")]
		[Address(RVA = "0x320A890", Offset = "0x3209490", VA = "0x18320A890")]
		public void Get(IntPtr L, int index, out Vector3 val)
		{
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003486")]
		[Address(RVA = "0x32116A0", Offset = "0x32102A0", VA = "0x1832116A0")]
		public void UpdateUnityEngineVector3(IntPtr L, int index, Vector3 val)
		{
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x320E340", Offset = "0x320CF40", VA = "0x18320E340")]
		public void PushUnityEngineVector4(IntPtr L, Vector4 val)
		{
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003488")]
		[Address(RVA = "0x320A3A0", Offset = "0x3208FA0", VA = "0x18320A3A0")]
		public void Get(IntPtr L, int index, out Vector4 val)
		{
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003489")]
		[Address(RVA = "0x32118C0", Offset = "0x32104C0", VA = "0x1832118C0")]
		public void UpdateUnityEngineVector4(IntPtr L, int index, Vector4 val)
		{
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348A")]
		[Address(RVA = "0x320D9B0", Offset = "0x320C5B0", VA = "0x18320D9B0")]
		public void PushUnityEngineColor(IntPtr L, Color val)
		{
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348B")]
		[Address(RVA = "0x3209A70", Offset = "0x3208670", VA = "0x183209A70")]
		public void Get(IntPtr L, int index, out Color val)
		{
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348C")]
		[Address(RVA = "0x3210BD0", Offset = "0x320F7D0", VA = "0x183210BD0")]
		public void UpdateUnityEngineColor(IntPtr L, int index, Color val)
		{
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348D")]
		[Address(RVA = "0x320DB50", Offset = "0x320C750", VA = "0x18320DB50")]
		public void PushUnityEngineQuaternion(IntPtr L, Quaternion val)
		{
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348E")]
		[Address(RVA = "0x3209280", Offset = "0x3207E80", VA = "0x183209280")]
		public void Get(IntPtr L, int index, out Quaternion val)
		{
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348F")]
		[Address(RVA = "0x3210E00", Offset = "0x320FA00", VA = "0x183210E00")]
		public void UpdateUnityEngineQuaternion(IntPtr L, int index, Quaternion val)
		{
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003490")]
		[Address(RVA = "0x320DEB0", Offset = "0x320CAB0", VA = "0x18320DEB0")]
		public void PushUnityEngineRay(IntPtr L, Ray val)
		{
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003491")]
		[Address(RVA = "0x32068C0", Offset = "0x32054C0", VA = "0x1832068C0")]
		public void Get(IntPtr L, int index, out Ray val)
		{
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003492")]
		[Address(RVA = "0x3211290", Offset = "0x320FE90", VA = "0x183211290")]
		public void UpdateUnityEngineRay(IntPtr L, int index, Ray val)
		{
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003493")]
		[Address(RVA = "0x320D820", Offset = "0x320C420", VA = "0x18320D820")]
		public void PushUnityEngineBounds(IntPtr L, Bounds val)
		{
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003494")]
		[Address(RVA = "0x3208350", Offset = "0x3206F50", VA = "0x183208350")]
		public void Get(IntPtr L, int index, out Bounds val)
		{
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003495")]
		[Address(RVA = "0x32109C0", Offset = "0x320F5C0", VA = "0x1832109C0")]
		public void UpdateUnityEngineBounds(IntPtr L, int index, Bounds val)
		{
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003496")]
		[Address(RVA = "0x320DCF0", Offset = "0x320C8F0", VA = "0x18320DCF0")]
		public void PushUnityEngineRay2D(IntPtr L, Ray2D val)
		{
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003497")]
		[Address(RVA = "0x3207900", Offset = "0x3206500", VA = "0x183207900")]
		public void Get(IntPtr L, int index, out Ray2D val)
		{
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003498")]
		[Address(RVA = "0x3211030", Offset = "0x320FC30", VA = "0x183211030")]
		public void UpdateUnityEngineRay2D(IntPtr L, int index, Ray2D val)
		{
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003499")]
		[Address(RVA = "0x320D1F0", Offset = "0x320BDF0", VA = "0x18320D1F0")]
		public void PushTorappuBattleAbilityStandardEvent(IntPtr L, AbilityStandard.Event val)
		{
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349A")]
		[Address(RVA = "0x320A670", Offset = "0x3209270", VA = "0x18320A670")]
		public void Get(IntPtr L, int index, out AbilityStandard.Event val)
		{
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349B")]
		[Address(RVA = "0x32103F0", Offset = "0x320EFF0", VA = "0x1832103F0")]
		public void UpdateTorappuBattleAbilityStandardEvent(IntPtr L, int index, AbilityStandard.Event val)
		{
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349C")]
		[Address(RVA = "0x320D400", Offset = "0x320C000", VA = "0x18320D400")]
		public void PushTorappuBattleActionActionNodeSourceType(IntPtr L, ActionNode.SourceType val)
		{
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349D")]
		[Address(RVA = "0x3208C20", Offset = "0x3207820", VA = "0x183208C20")]
		public void Get(IntPtr L, int index, out ActionNode.SourceType val)
		{
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349E")]
		[Address(RVA = "0x32105E0", Offset = "0x320F1E0", VA = "0x1832105E0")]
		public void UpdateTorappuBattleActionActionNodeSourceType(IntPtr L, int index, ActionNode.SourceType val)
		{
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349F")]
		[Address(RVA = "0x320D610", Offset = "0x320C210", VA = "0x18320D610")]
		public void PushTorappuUIUISenderConcurrentType(IntPtr L, UISender.ConcurrentType val)
		{
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A0")]
		[Address(RVA = "0x3206D50", Offset = "0x3205950", VA = "0x183206D50")]
		public void Get(IntPtr L, int index, out UISender.ConcurrentType val)
		{
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A1")]
		[Address(RVA = "0x32107D0", Offset = "0x320F3D0", VA = "0x1832107D0")]
		public void UpdateTorappuUIUISenderConcurrentType(IntPtr L, int index, UISender.ConcurrentType val)
		{
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x320B780", Offset = "0x320A380", VA = "0x18320B780")]
		public void PushDGTweeningAutoPlay(IntPtr L, AutoPlay val)
		{
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x32076E0", Offset = "0x32062E0", VA = "0x1832076E0")]
		public void Get(IntPtr L, int index, out AutoPlay val)
		{
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x320EE60", Offset = "0x320DA60", VA = "0x18320EE60")]
		public void UpdateDGTweeningAutoPlay(IntPtr L, int index, AutoPlay val)
		{
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A5")]
		[Address(RVA = "0x320B990", Offset = "0x320A590", VA = "0x18320B990")]
		public void PushDGTweeningAxisConstraint(IntPtr L, AxisConstraint val)
		{
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A6")]
		[Address(RVA = "0x320A180", Offset = "0x3208D80", VA = "0x18320A180")]
		public void Get(IntPtr L, int index, out AxisConstraint val)
		{
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x320F050", Offset = "0x320DC50", VA = "0x18320F050")]
		public void UpdateDGTweeningAxisConstraint(IntPtr L, int index, AxisConstraint val)
		{
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x320BBA0", Offset = "0x320A7A0", VA = "0x18320BBA0")]
		public void PushDGTweeningEase(IntPtr L, Ease val)
		{
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x3208A00", Offset = "0x3207600", VA = "0x183208A00")]
		public void Get(IntPtr L, int index, out Ease val)
		{
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x320F240", Offset = "0x320DE40", VA = "0x18320F240")]
		public void UpdateDGTweeningEase(IntPtr L, int index, Ease val)
		{
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x320BDB0", Offset = "0x320A9B0", VA = "0x18320BDB0")]
		public void PushDGTweeningLogBehaviour(IntPtr L, LogBehaviour val)
		{
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x3209F60", Offset = "0x3208B60", VA = "0x183209F60")]
		public void Get(IntPtr L, int index, out LogBehaviour val)
		{
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AD")]
		[Address(RVA = "0x320F430", Offset = "0x320E030", VA = "0x18320F430")]
		public void UpdateDGTweeningLogBehaviour(IntPtr L, int index, LogBehaviour val)
		{
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AE")]
		[Address(RVA = "0x320BFC0", Offset = "0x320ABC0", VA = "0x18320BFC0")]
		public void PushDGTweeningLoopType(IntPtr L, LoopType val)
		{
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AF")]
		[Address(RVA = "0x3208E40", Offset = "0x3207A40", VA = "0x183208E40")]
		public void Get(IntPtr L, int index, out LoopType val)
		{
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B0")]
		[Address(RVA = "0x320F620", Offset = "0x320E220", VA = "0x18320F620")]
		public void UpdateDGTweeningLoopType(IntPtr L, int index, LoopType val)
		{
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B1")]
		[Address(RVA = "0x320C1D0", Offset = "0x320ADD0", VA = "0x18320C1D0")]
		public void PushDGTweeningPathMode(IntPtr L, PathMode val)
		{
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B2")]
		[Address(RVA = "0x3209D40", Offset = "0x3208940", VA = "0x183209D40")]
		public void Get(IntPtr L, int index, out PathMode val)
		{
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B3")]
		[Address(RVA = "0x320F810", Offset = "0x320E410", VA = "0x18320F810")]
		public void UpdateDGTweeningPathMode(IntPtr L, int index, PathMode val)
		{
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x320C3E0", Offset = "0x320AFE0", VA = "0x18320C3E0")]
		public void PushDGTweeningPathType(IntPtr L, PathType val)
		{
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x32074C0", Offset = "0x32060C0", VA = "0x1832074C0")]
		public void Get(IntPtr L, int index, out PathType val)
		{
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x320FA00", Offset = "0x320E600", VA = "0x18320FA00")]
		public void UpdateDGTweeningPathType(IntPtr L, int index, PathType val)
		{
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x320C5F0", Offset = "0x320B1F0", VA = "0x18320C5F0")]
		public void PushDGTweeningRotateMode(IntPtr L, RotateMode val)
		{
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x3209550", Offset = "0x3208150", VA = "0x183209550")]
		public void Get(IntPtr L, int index, out RotateMode val)
		{
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x320FBF0", Offset = "0x320E7F0", VA = "0x18320FBF0")]
		public void UpdateDGTweeningRotateMode(IntPtr L, int index, RotateMode val)
		{
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x320C810", Offset = "0x320B410", VA = "0x18320C810")]
		public void PushDGTweeningScrambleMode(IntPtr L, ScrambleMode val)
		{
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x3206F70", Offset = "0x3205B70", VA = "0x183206F70")]
		public void Get(IntPtr L, int index, out ScrambleMode val)
		{
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BC")]
		[Address(RVA = "0x320FDF0", Offset = "0x320E9F0", VA = "0x18320FDF0")]
		public void UpdateDGTweeningScrambleMode(IntPtr L, int index, ScrambleMode val)
		{
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BD")]
		[Address(RVA = "0x320CA30", Offset = "0x320B630", VA = "0x18320CA30")]
		public void PushDGTweeningTweenType(IntPtr L, TweenType val)
		{
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BE")]
		[Address(RVA = "0x32087E0", Offset = "0x32073E0", VA = "0x1832087E0")]
		public void Get(IntPtr L, int index, out TweenType val)
		{
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BF")]
		[Address(RVA = "0x320FFF0", Offset = "0x320EBF0", VA = "0x18320FFF0")]
		public void UpdateDGTweeningTweenType(IntPtr L, int index, TweenType val)
		{
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x320CC50", Offset = "0x320B850", VA = "0x18320CC50")]
		public void PushDGTweeningUpdateType(IntPtr L, UpdateType val)
		{
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x3209060", Offset = "0x3207C60", VA = "0x183209060")]
		public void Get(IntPtr L, int index, out UpdateType val)
		{
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x32101F0", Offset = "0x320EDF0", VA = "0x1832101F0")]
		public void UpdateDGTweeningUpdateType(IntPtr L, int index, UpdateType val)
		{
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x3207D00", Offset = "0x3206900", VA = "0x183207D00")]
		public void Get(IntPtr L, int index, out Context.Snapshot val)
		{
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000142")]
		private static XLua_Gen_Initer_Register__ gen_reg_dumb_obj
		{
			[Token(Token = "0x60034C4")]
			[Address(RVA = "0x32146E0", Offset = "0x32132E0", VA = "0x1832146E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x3205F20", Offset = "0x3204B20", VA = "0x183205F20")]
		public void DelayWrapLoader(Type type, Action<IntPtr> loader)
		{
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x3204F40", Offset = "0x3203B40", VA = "0x183204F40")]
		public void AddInterfaceBridgeCreator(Type type, Func<int, LuaEnv, LuaBase> creator)
		{
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00015E40 File Offset: 0x00014040
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x320EB40", Offset = "0x320D740", VA = "0x18320EB40")]
		public bool TryDelayWrapLoader(IntPtr L, Type type)
		{
			return default(bool);
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C8")]
		[Address(RVA = "0x3204FB0", Offset = "0x3203BB0", VA = "0x183204FB0")]
		public void Alias(Type type, string alias)
		{
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x32127F0", Offset = "0x32113F0", VA = "0x1832127F0")]
		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name)
		{
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x3211D50", Offset = "0x3210950", VA = "0x183211D50")]
		public ObjectTranslator(LuaEnv luaenv, IntPtr L)
		{
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void initCSharpCallLua()
		{
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x32130C0", Offset = "0x3211CC0", VA = "0x1832130C0")]
		private Delegate getDelegateUsingGeneric(DelegateBridgeBase bridge, Type delegateType, MethodInfo delegateMethod)
		{
			return null;
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x3213CD0", Offset = "0x32128D0", VA = "0x183213CD0")]
		private Delegate getDelegate(DelegateBridgeBase bridge, Type delegateType)
		{
			return null;
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x32055D0", Offset = "0x32041D0", VA = "0x1832055D0")]
		public object CreateDelegateBridge(IntPtr L, Type delegateType, int idx)
		{
			return null;
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00015E58 File Offset: 0x00014058
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x32050D0", Offset = "0x3203CD0", VA = "0x1832050D0")]
		public bool AllDelegateBridgeReleased()
		{
			return default(bool);
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0x320E8A0", Offset = "0x320D4A0", VA = "0x18320E8A0")]
		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate)
		{
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x3205DD0", Offset = "0x32049D0", VA = "0x183205DD0")]
		public object CreateInterfaceBridge(IntPtr L, Type interfaceType, int idx)
		{
			return null;
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x3205400", Offset = "0x3204000", VA = "0x183205400")]
		public void CreateArrayMetatable(IntPtr L)
		{
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x3205A70", Offset = "0x3204670", VA = "0x183205A70")]
		public void CreateDelegateMetatable(IntPtr L)
		{
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x3205C70", Offset = "0x3204870", VA = "0x183205C70")]
		internal void CreateEnumerablePairs(IntPtr L)
		{
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x320ACA0", Offset = "0x32098A0", VA = "0x18320ACA0")]
		public void OpenLib(IntPtr L)
		{
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D6")]
		[Address(RVA = "0x3212D00", Offset = "0x3211900", VA = "0x183212D00")]
		internal void createFunctionMetatable(IntPtr L)
		{
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D7")]
		[Address(RVA = "0x3205FE0", Offset = "0x3204BE0", VA = "0x183205FE0")]
		internal Type FindType(string className, bool isQualifiedName = false)
		{
			return null;
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x00015E70 File Offset: 0x00014070
		[Token(Token = "0x60034D8")]
		[Address(RVA = "0x3214730", Offset = "0x3213330", VA = "0x183214730")]
		private bool hasMethod(Type type, string methodName)
		{
			return default(bool);
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D9")]
		[Address(RVA = "0x3212BE0", Offset = "0x32117E0", VA = "0x183212BE0")]
		internal void collectObject(int obj_index_to_collect)
		{
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x00015E88 File Offset: 0x00014088
		[Token(Token = "0x60034DA")]
		[Address(RVA = "0x3212B20", Offset = "0x3211720", VA = "0x183212B20")]
		private int addObject(object obj, bool is_valuetype, bool is_enum)
		{
			return 0;
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DB")]
		[Address(RVA = "0x3206630", Offset = "0x3205230", VA = "0x183206630")]
		internal object GetObject(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DC")]
		[Address(RVA = "0x3206830", Offset = "0x3205430", VA = "0x183206830")]
		public Type GetTypeOf(IntPtr L, int idx)
		{
			return null;
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x00015EA0 File Offset: 0x000140A0
		[Token(Token = "0x60034DD")]
		public bool Assignable<T>(IntPtr L, int index)
		{
			return default(bool);
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x00015EB8 File Offset: 0x000140B8
		[Token(Token = "0x60034DE")]
		[Address(RVA = "0x3205250", Offset = "0x3203E50", VA = "0x183205250")]
		public bool Assignable(IntPtr L, int index, Type type)
		{
			return default(bool);
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DF")]
		[Address(RVA = "0x32063F0", Offset = "0x3204FF0", VA = "0x1832063F0")]
		public object GetObject(IntPtr L, int index, Type type)
		{
			return null;
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E0")]
		public void Get<T>(IntPtr L, int index, out T v)
		{
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E1")]
		public void PushByType<T>(IntPtr L, T v)
		{
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E2")]
		public T[] GetParams<T>(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x3206700", Offset = "0x3205300", VA = "0x183206700")]
		public Array GetParams(IntPtr L, int index, Type type)
		{
			return null;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E4")]
		public T GetDelegate<T>(IntPtr L, int index) where T : class
		{
			return null;
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x00015ED0 File Offset: 0x000140D0
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x3206800", Offset = "0x3205400", VA = "0x183206800")]
		public int GetTypeId(IntPtr L, Type type)
		{
			return 0;
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x320B260", Offset = "0x3209E60", VA = "0x18320B260")]
		public void PrivateAccessible(IntPtr L, Type type)
		{
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x00015EE8 File Offset: 0x000140E8
		[Token(Token = "0x60034E7")]
		[Address(RVA = "0x3214070", Offset = "0x3212C70", VA = "0x183214070")]
		internal int getTypeId(IntPtr L, Type type, out bool is_first, ObjectTranslator.LOGLEVEL log_level = ObjectTranslator.LOGLEVEL.WARN)
		{
			return 0;
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0x3214BB0", Offset = "0x32137B0", VA = "0x183214BB0")]
		private void pushPrimitive(IntPtr L, object o)
		{
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E9")]
		[Address(RVA = "0x320B330", Offset = "0x3209F30", VA = "0x18320B330")]
		public void PushAny(IntPtr L, object o)
		{
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x00015F00 File Offset: 0x00014100
		[Token(Token = "0x60034EA")]
		[Address(RVA = "0x320EA40", Offset = "0x320D640", VA = "0x18320EA40")]
		public int TranslateToEnumToTop(IntPtr L, Type type, int idx)
		{
			return 0;
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EB")]
		[Address(RVA = "0x320E750", Offset = "0x320D350", VA = "0x18320E750")]
		public void Push(IntPtr L, lua_CSFunction o)
		{
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EC")]
		[Address(RVA = "0x320E6F0", Offset = "0x320D2F0", VA = "0x18320E6F0")]
		public void Push(IntPtr L, LuaBase o)
		{
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034ED")]
		[Address(RVA = "0x320E4E0", Offset = "0x320D0E0", VA = "0x18320E4E0")]
		public void Push(IntPtr L, object o)
		{
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EE")]
		[Address(RVA = "0x320D0B0", Offset = "0x320BCB0", VA = "0x18320D0B0")]
		public void PushObject(IntPtr L, object o, int type_id)
		{
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EF")]
		[Address(RVA = "0x3211AF0", Offset = "0x32106F0", VA = "0x183211AF0")]
		public void Update(IntPtr L, int index, object obj)
		{
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F0")]
		[Address(RVA = "0x3212E90", Offset = "0x3211A90", VA = "0x183212E90")]
		private object getCsObj(IntPtr L, int index, int udata)
		{
			return null;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F1")]
		[Address(RVA = "0x320E9F0", Offset = "0x320D5F0", VA = "0x18320E9F0")]
		internal object SafeGetCSObj(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F2")]
		[Address(RVA = "0x3205F90", Offset = "0x3204B90", VA = "0x183205F90")]
		internal object FastGetCSObj(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F3")]
		[Address(RVA = "0x320E7D0", Offset = "0x320D3D0", VA = "0x18320E7D0")]
		internal void ReleaseCSObj(IntPtr L, int index)
		{
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F4")]
		[Address(RVA = "0x3206390", Offset = "0x3204F90", VA = "0x183206390")]
		internal lua_CSFunction GetFixCSFunction(int index)
		{
			return null;
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F5")]
		[Address(RVA = "0x320CFE0", Offset = "0x320BBE0", VA = "0x18320CFE0")]
		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func)
		{
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F6")]
		[Address(RVA = "0x3214810", Offset = "0x3213410", VA = "0x183214810")]
		internal object[] popValues(IntPtr L, int oldTop)
		{
			return null;
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F7")]
		[Address(RVA = "0x32149E0", Offset = "0x32135E0", VA = "0x1832149E0")]
		internal object[] popValues(IntPtr L, int oldTop, Type[] popTypes)
		{
			return null;
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x3215020", Offset = "0x3213C20", VA = "0x183215020")]
		private void registerCustomOp(Type type, ObjectTranslator.PushCSObject push, ObjectTranslator.GetCSObject get, ObjectTranslator.UpdateCSObject update)
		{
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x00015F18 File Offset: 0x00014118
		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x320AC00", Offset = "0x3209800", VA = "0x18320AC00")]
		public bool HasCustomOp(Type type)
		{
			return default(bool);
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00015F30 File Offset: 0x00014130
		[Token(Token = "0x60034FA")]
		private bool tryGetPushFuncByType<T>(Type type, out T func) where T : class
		{
			return default(bool);
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00015F48 File Offset: 0x00014148
		[Token(Token = "0x60034FB")]
		private bool tryGetGetFuncByType<T>(Type type, out T func) where T : class
		{
			return default(bool);
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FC")]
		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, ObjectTranslator.GetFunc<T> get, Action<IntPtr, int, T> update)
		{
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FD")]
		public void RegisterCaster<T>(ObjectTranslator.GetFunc<T> get)
		{
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x320CE70", Offset = "0x320BA70", VA = "0x18320CE70")]
		public void PushDecimal(IntPtr L, decimal val)
		{
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00015F60 File Offset: 0x00014160
		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x320AC60", Offset = "0x3209860", VA = "0x18320AC60")]
		public bool IsDecimal(IntPtr L, int index)
		{
			return default(bool);
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00015F78 File Offset: 0x00014178
		[Token(Token = "0x6003500")]
		[Address(RVA = "0x3206350", Offset = "0x3204F50", VA = "0x183206350")]
		public decimal GetDecimal(IntPtr L, int index)
		{
			return 0m;
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003501")]
		[Address(RVA = "0x3209770", Offset = "0x3208370", VA = "0x183209770")]
		public void Get(IntPtr L, int index, out decimal val)
		{
		}

		// Token: 0x04000C77 RID: 3191
		[Token(Token = "0x4000C77")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectTranslator.IniterAdderUnityEngineVector2 s_IniterAdderUnityEngineVector2_dumb_obj;

		// Token: 0x04000C78 RID: 3192
		[Token(Token = "0x4000C78")]
		[FieldOffset(Offset = "0x10")]
		private int UnityEngineVector2_TypeID;

		// Token: 0x04000C79 RID: 3193
		[Token(Token = "0x4000C79")]
		[FieldOffset(Offset = "0x14")]
		private int UnityEngineVector3_TypeID;

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x18")]
		private int UnityEngineVector4_TypeID;

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x1C")]
		private int UnityEngineColor_TypeID;

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x20")]
		private int UnityEngineQuaternion_TypeID;

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x24")]
		private int UnityEngineRay_TypeID;

		// Token: 0x04000C7E RID: 3198
		[Token(Token = "0x4000C7E")]
		[FieldOffset(Offset = "0x28")]
		private int UnityEngineBounds_TypeID;

		// Token: 0x04000C7F RID: 3199
		[Token(Token = "0x4000C7F")]
		[FieldOffset(Offset = "0x2C")]
		private int UnityEngineRay2D_TypeID;

		// Token: 0x04000C80 RID: 3200
		[Token(Token = "0x4000C80")]
		[FieldOffset(Offset = "0x30")]
		private int TorappuBattleAbilityStandardEvent_TypeID;

		// Token: 0x04000C81 RID: 3201
		[Token(Token = "0x4000C81")]
		[FieldOffset(Offset = "0x34")]
		private int TorappuBattleAbilityStandardEvent_EnumRef;

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		[FieldOffset(Offset = "0x38")]
		private int TorappuBattleActionActionNodeSourceType_TypeID;

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		[FieldOffset(Offset = "0x3C")]
		private int TorappuBattleActionActionNodeSourceType_EnumRef;

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		[FieldOffset(Offset = "0x40")]
		private int TorappuUIUISenderConcurrentType_TypeID;

		// Token: 0x04000C85 RID: 3205
		[Token(Token = "0x4000C85")]
		[FieldOffset(Offset = "0x44")]
		private int TorappuUIUISenderConcurrentType_EnumRef;

		// Token: 0x04000C86 RID: 3206
		[Token(Token = "0x4000C86")]
		[FieldOffset(Offset = "0x48")]
		private int DGTweeningAutoPlay_TypeID;

		// Token: 0x04000C87 RID: 3207
		[Token(Token = "0x4000C87")]
		[FieldOffset(Offset = "0x4C")]
		private int DGTweeningAutoPlay_EnumRef;

		// Token: 0x04000C88 RID: 3208
		[Token(Token = "0x4000C88")]
		[FieldOffset(Offset = "0x50")]
		private int DGTweeningAxisConstraint_TypeID;

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		[FieldOffset(Offset = "0x54")]
		private int DGTweeningAxisConstraint_EnumRef;

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		[FieldOffset(Offset = "0x58")]
		private int DGTweeningEase_TypeID;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		[FieldOffset(Offset = "0x5C")]
		private int DGTweeningEase_EnumRef;

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4000C8C")]
		[FieldOffset(Offset = "0x60")]
		private int DGTweeningLogBehaviour_TypeID;

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		[FieldOffset(Offset = "0x64")]
		private int DGTweeningLogBehaviour_EnumRef;

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		[FieldOffset(Offset = "0x68")]
		private int DGTweeningLoopType_TypeID;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		[FieldOffset(Offset = "0x6C")]
		private int DGTweeningLoopType_EnumRef;

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		[FieldOffset(Offset = "0x70")]
		private int DGTweeningPathMode_TypeID;

		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		[FieldOffset(Offset = "0x74")]
		private int DGTweeningPathMode_EnumRef;

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		[FieldOffset(Offset = "0x78")]
		private int DGTweeningPathType_TypeID;

		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0x7C")]
		private int DGTweeningPathType_EnumRef;

		// Token: 0x04000C94 RID: 3220
		[Token(Token = "0x4000C94")]
		[FieldOffset(Offset = "0x80")]
		private int DGTweeningRotateMode_TypeID;

		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x84")]
		private int DGTweeningRotateMode_EnumRef;

		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x88")]
		private int DGTweeningScrambleMode_TypeID;

		// Token: 0x04000C97 RID: 3223
		[Token(Token = "0x4000C97")]
		[FieldOffset(Offset = "0x8C")]
		private int DGTweeningScrambleMode_EnumRef;

		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		[FieldOffset(Offset = "0x90")]
		private int DGTweeningTweenType_TypeID;

		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x94")]
		private int DGTweeningTweenType_EnumRef;

		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x98")]
		private int DGTweeningUpdateType_TypeID;

		// Token: 0x04000C9B RID: 3227
		[Token(Token = "0x4000C9B")]
		[FieldOffset(Offset = "0x9C")]
		private int DGTweeningUpdateType_EnumRef;

		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4000C9C")]
		[FieldOffset(Offset = "0x8")]
		private static XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj;

		// Token: 0x04000C9D RID: 3229
		[Token(Token = "0x4000C9D")]
		[FieldOffset(Offset = "0xA0")]
		internal MethodWrapsCache methodWrapsCache;

		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		[FieldOffset(Offset = "0xA8")]
		internal ObjectCheckers objectCheckers;

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0xB0")]
		internal ObjectCasters objectCasters;

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0xB8")]
		internal readonly ObjectPool objects;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly Dictionary<object, int> reverseMap;

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0xC8")]
		internal LuaEnv luaEnv;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0xD0")]
		internal StaticLuaCallbacks metaFunctions;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		[FieldOffset(Offset = "0xD8")]
		internal List<Assembly> assemblies;

		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4000CA5")]
		[FieldOffset(Offset = "0xE0")]
		private lua_CSFunction importTypeFunction;

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		[FieldOffset(Offset = "0xE8")]
		private lua_CSFunction loadAssemblyFunction;

		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4000CA7")]
		[FieldOffset(Offset = "0xF0")]
		private lua_CSFunction castFunction;

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0xF8")]
		private readonly Dictionary<Type, Action<IntPtr>> delayWrap;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x100")]
		private readonly Dictionary<Type, Func<int, LuaEnv, LuaBase>> interfaceBridgeCreators;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x108")]
		private readonly Dictionary<Type, Type> aliasCfg;

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x110")]
		private Dictionary<Type, bool> loaded_types;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x118")]
		public int cacheRef;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0x120")]
		private MethodInfo[] genericAction;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0x128")]
		private MethodInfo[] genericFunc;

		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4000CAF")]
		[FieldOffset(Offset = "0x130")]
		private Dictionary<Type, Func<DelegateBridgeBase, Delegate>> genericDelegateCreatorCache;

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x138")]
		private Dictionary<int, WeakReference> delegate_bridges;

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4000CB1")]
		[FieldOffset(Offset = "0x140")]
		private int common_array_meta;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x144")]
		private int common_delegate_meta;

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x148")]
		private int enumerable_pairs_func;

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x150")]
		private Dictionary<Type, int> typeIdMap;

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x158")]
		private Dictionary<int, Type> typeMap;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x160")]
		private HashSet<Type> privateAccessibleFlags;

		// Token: 0x04000CB7 RID: 3255
		[Token(Token = "0x4000CB7")]
		[FieldOffset(Offset = "0x168")]
		private Dictionary<object, int> enumMap;

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x170")]
		private List<lua_CSFunction> fix_cs_functions;

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x178")]
		private Dictionary<Type, ObjectTranslator.PushCSObject> custom_push_funcs;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x180")]
		private Dictionary<Type, ObjectTranslator.GetCSObject> custom_get_funcs;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x188")]
		private Dictionary<Type, ObjectTranslator.UpdateCSObject> custom_update_funcs;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x190")]
		private Dictionary<Type, Delegate> push_func_with_type;

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x198")]
		private Dictionary<Type, Delegate> get_func_with_type;

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x1A0")]
		private int decimal_type_id;

		// Token: 0x02000251 RID: 593
		[Token(Token = "0x2000251")]
		private class IniterAdderUnityEngineVector2
		{
			// Token: 0x06003505 RID: 13573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003505")]
			[Address(RVA = "0x331D0E0", Offset = "0x331BCE0", VA = "0x18331D0E0")]
			private static void Init(LuaEnv luaenv, ObjectTranslator translator)
			{
			}

			// Token: 0x06003506 RID: 13574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003506")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IniterAdderUnityEngineVector2()
			{
			}
		}

		// Token: 0x02000252 RID: 594
		[Token(Token = "0x2000252")]
		internal enum LOGLEVEL
		{
			// Token: 0x04000CC0 RID: 3264
			[Token(Token = "0x4000CC0")]
			NO,
			// Token: 0x04000CC1 RID: 3265
			[Token(Token = "0x4000CC1")]
			INFO,
			// Token: 0x04000CC2 RID: 3266
			[Token(Token = "0x4000CC2")]
			WARN,
			// Token: 0x04000CC3 RID: 3267
			[Token(Token = "0x4000CC3")]
			ERROR
		}

		// Token: 0x02000253 RID: 595
		// (Invoke) Token: 0x06003508 RID: 13576
		[Token(Token = "0x2000253")]
		public delegate void PushCSObject(IntPtr L, object obj);

		// Token: 0x02000254 RID: 596
		// (Invoke) Token: 0x0600350C RID: 13580
		[Token(Token = "0x2000254")]
		public delegate object GetCSObject(IntPtr L, int idx);

		// Token: 0x02000255 RID: 597
		// (Invoke) Token: 0x06003510 RID: 13584
		[Token(Token = "0x2000255")]
		public delegate void UpdateCSObject(IntPtr L, int idx, object obj);

		// Token: 0x02000256 RID: 598
		// (Invoke) Token: 0x06003514 RID: 13588
		[Token(Token = "0x2000256")]
		public delegate void GetFunc<T>(IntPtr L, int idx, out T val);
	}
}
