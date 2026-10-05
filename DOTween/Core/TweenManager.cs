using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;

namespace DG.Tweening.Core
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	internal static class TweenManager
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600042D")]
		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x3760230", Offset = "0x375EE30", VA = "0x183760230")]
		internal static Sequence GetSequence()
		{
			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x3762720", Offset = "0x3761320", VA = "0x183762720")]
		internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x375DBD0", Offset = "0x375C7D0", VA = "0x18375DBD0")]
		internal static void AddActiveTweenToSequence(Tween t)
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x375E440", Offset = "0x375D040", VA = "0x18375E440")]
		internal static int DespawnAll()
		{
			return 0;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x375E750", Offset = "0x375D350", VA = "0x18375E750")]
		internal static void Despawn(Tween t, bool modifyActiveLists = true)
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x3761230", Offset = "0x375FE30", VA = "0x183761230")]
		internal static void PurgeAll(bool isApplicationQuitting)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x3761710", Offset = "0x3760310", VA = "0x183761710")]
		internal static void PurgePools()
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x375DFC0", Offset = "0x375CBC0", VA = "0x18375DFC0")]
		internal static void AddTweenLink(Tween t, TweenLink tweenLink)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x3761E60", Offset = "0x3760A60", VA = "0x183761E60")]
		private static void RemoveTweenLink(Tween t)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x3762240", Offset = "0x3760E40", VA = "0x183762240")]
		internal static void ResetCapacities()
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x3762600", Offset = "0x3761200", VA = "0x183762600")]
		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity)
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x3763490", Offset = "0x3762090", VA = "0x183763490")]
		internal static int Validate()
		{
			return 0;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x3762EC0", Offset = "0x3761AC0", VA = "0x183762EC0")]
		internal static void Update(UpdateType updateType, float deltaTime, float independentTime)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x37631E0", Offset = "0x3761DE0", VA = "0x1837631E0")]
		internal static bool Update(Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate)
		{
			return default(bool);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x375F380", Offset = "0x375DF80", VA = "0x18375F380")]
		internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat, [Optional] object optionalObj, [Optional] object[] optionalArray)
		{
			return 0;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x375E260", Offset = "0x375CE60", VA = "0x18375E260")]
		internal static bool Complete(Tween t, bool modifyActiveLists = true, UpdateMode updateMode = UpdateMode.Goto)
		{
			return default(bool);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x375FF50", Offset = "0x375EB50", VA = "0x18375FF50")]
		internal static bool Flip(Tween t)
		{
			return default(bool);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x375FF70", Offset = "0x375EB70", VA = "0x18375FF70")]
		internal static void ForceInit(Tween t, bool isSequenced = false)
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x37608A0", Offset = "0x375F4A0", VA = "0x1837608A0")]
		internal static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = UpdateMode.Goto)
		{
			return default(bool);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x3760DE0", Offset = "0x375F9E0", VA = "0x183760DE0")]
		internal static bool Pause(Tween t)
		{
			return default(bool);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x37611A0", Offset = "0x375FDA0", VA = "0x1837611A0")]
		internal static bool Play(Tween t)
		{
			return default(bool);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x3760E30", Offset = "0x375FA30", VA = "0x183760E30")]
		internal static bool PlayBackwards(Tween t)
		{
			return default(bool);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x3761030", Offset = "0x375FC30", VA = "0x183761030")]
		internal static bool PlayForward(Tween t)
		{
			return default(bool);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x3762380", Offset = "0x3760F80", VA = "0x183762380")]
		internal static bool Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return default(bool);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x3762460", Offset = "0x3761060", VA = "0x183762460")]
		internal static bool Rewind(Tween t, bool includeDelay = true)
		{
			return default(bool);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x37629E0", Offset = "0x37615E0", VA = "0x1837629E0")]
		internal static bool SmoothRewind(Tween t)
		{
			return default(bool);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x3762B50", Offset = "0x3761750", VA = "0x183762B50")]
		internal static bool TogglePause(Tween t)
		{
			return default(bool);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x3762D90", Offset = "0x3761990", VA = "0x183762D90")]
		internal static int TotalPooledTweens()
		{
			return 0;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x3762C60", Offset = "0x3761860", VA = "0x183762C60")]
		internal static int TotalPlayingTweens()
		{
			return 0;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x3762DE0", Offset = "0x37619E0", VA = "0x183762DE0")]
		internal static int TotalTweensById(object id, bool playingOnly)
		{
			return 0;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x3760050", Offset = "0x375EC50", VA = "0x183760050")]
		internal static List<Tween> GetActiveTweens(bool playing, [Optional] List<Tween> fillableList)
		{
			return null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x3760540", Offset = "0x375F140", VA = "0x183760540")]
		internal static List<Tween> GetTweensById(object id, bool playingOnly, [Optional] List<Tween> fillableList)
		{
			return null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x375ED90", Offset = "0x375D990", VA = "0x18375ED90")]
		private static int DoGetTweensById(object id, bool playingOnly, bool addToList, List<Tween> fillableList)
		{
			return 0;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x37606B0", Offset = "0x375F2B0", VA = "0x1837606B0")]
		internal static List<Tween> GetTweensByTarget(object target, bool playingOnly, [Optional] List<Tween> fillableList)
		{
			return null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x3760CF0", Offset = "0x375F8F0", VA = "0x183760CF0")]
		private static void MarkForKilling(Tween t, bool isSingleTweenManualUpdate = false)
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x375EFD0", Offset = "0x375DBD0", VA = "0x18375EFD0")]
		private static void EvaluateTweenLink(Tween t)
		{
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x375DC20", Offset = "0x375C820", VA = "0x18375DC20")]
		private static void AddActiveTween(Tween t)
		{
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x3761F40", Offset = "0x3760B40", VA = "0x183761F40")]
		private static void ReorganizeActiveTweens()
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x375E380", Offset = "0x375CF80", VA = "0x18375E380")]
		private static void DespawnActiveTweens(List<Tween> tweens)
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x3761870", Offset = "0x3760470", VA = "0x183761870")]
		private static void RemoveActiveTween(Tween t)
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x375E1F0", Offset = "0x375CDF0", VA = "0x18375E1F0")]
		private static void ClearTweenArray(Tween[] tweens)
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x3760A10", Offset = "0x375F610", VA = "0x183760A10")]
		private static void IncreaseCapacities(TweenManager.CapacityIncreaseMode increaseMode)
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x3760C30", Offset = "0x375F830", VA = "0x183760C30")]
		private static void ManageOnRewindCallbackWhenAlreadyRewinded(Tween t, bool isPlayBackwardsOrSmoothRewind)
		{
		}

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		private const int _DefaultMaxTweeners = 200;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		private const int _DefaultMaxSequences = 50;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup";

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		private const float _EpsilonVsTimeCheck = 1E-06f;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool isUnityEditor;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal static bool isDebugBuild;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal static int maxActive;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static int maxTweeners;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal static int maxSequences;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static bool hasActiveTweens;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		internal static bool hasActiveDefaultTweens;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		internal static bool hasActiveLateTweens;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		internal static bool hasActiveFixedTweens;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal static bool hasActiveManualTweens;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static int totActiveTweens;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal static int totActiveDefaultTweens;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static int totActiveLateTweens;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal static int totActiveFixedTweens;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static int totActiveManualTweens;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal static int totActiveTweeners;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static int totActiveSequences;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal static int totPooledTweeners;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal static int totPooledSequences;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal static int totTweeners;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal static int totSequences;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal static bool isUpdateLoop;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal static Tween[] _activeTweens;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Tween[] _pooledTweeners;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly Stack<Tween> _PooledSequences;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly List<Tween> _KillList;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly Dictionary<Tween, TweenLink> _TweenLinks;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static int _totTweenLinks;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static int _maxActiveLookupId;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static bool _requiresActiveReorganization;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private static int _reorganizeFromId;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static int _minPooledTweenerId;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private static int _maxPooledTweenerId;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static bool _despawnAllCalledFromUpdateLoopCallback;

		// Token: 0x020000B7 RID: 183
		[Token(Token = "0x20000B7")]
		internal enum CapacityIncreaseMode
		{
			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			TweenersAndSequences,
			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			TweenersOnly,
			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			SequencesOnly
		}
	}
}
