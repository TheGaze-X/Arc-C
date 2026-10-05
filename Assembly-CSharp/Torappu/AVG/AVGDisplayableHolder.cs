using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E42 RID: 7746
	[Token(Token = "0x2001E42")]
	public abstract class AVGDisplayableHolder : MonoBehaviour, IHotfixable, IDisposable
	{
		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x0600BFC6 RID: 49094 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BFC7 RID: 49095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700172C")]
		private protected GameObject contentObject
		{
			[Token(Token = "0x600BFC6")]
			[Address(RVA = "0x33DC010", Offset = "0x33DAC10", VA = "0x1833DC010")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600BFC7")]
			[Address(RVA = "0x33DC070", Offset = "0x33DAC70", VA = "0x1833DC070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600BFC8 RID: 49096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC8")]
		[Address(RVA = "0x33D9C00", Offset = "0x33D8800", VA = "0x1833D9C00")]
		public void Display(Command command, out Tween tween)
		{
		}

		// Token: 0x0600BFC9 RID: 49097
		[Token(Token = "0x600BFC9")]
		public abstract GameObject GenerateContent(AVGDisplayableHolder.AVGDisplayParam param);

		// Token: 0x0600BFCA RID: 49098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCA")]
		[Address(RVA = "0x33DA260", Offset = "0x33D8E60", VA = "0x1833DA260", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600BFCB RID: 49099 RVA: 0x00046B78 File Offset: 0x00044D78
		[Token(Token = "0x600BFCB")]
		[Address(RVA = "0x33DBD50", Offset = "0x33DA950", VA = "0x1833DBD50")]
		private AVGControllerSceneCanvas _GetCanvas(AVGDisplaySlot slot)
		{
			return AVGControllerSceneCanvas.NONE;
		}

		// Token: 0x0600BFCC RID: 49100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCC")]
		[Address(RVA = "0x33DBE00", Offset = "0x33DAA00", VA = "0x1833DBE00")]
		private void _LoadContentIfNeed(AVGDisplayableHolder.AVGDisplayParam param)
		{
		}

		// Token: 0x0600BFCD RID: 49101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCD")]
		[Address(RVA = "0x33DAB10", Offset = "0x33D9710", VA = "0x1833DAB10")]
		private void _ApplyFeatures(Command command, out List<Tween> featureTweens)
		{
		}

		// Token: 0x0600BFCE RID: 49102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCE")]
		[Address(RVA = "0x33DA390", Offset = "0x33D8F90", VA = "0x1833DA390")]
		private void _AddTweenToList(ref List<Tween> tweens, Tween tween)
		{
		}

		// Token: 0x0600BFCF RID: 49103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCF")]
		[Address(RVA = "0x33DB170", Offset = "0x33D9D70", VA = "0x1833DB170")]
		private static void _ApplyPositionFeature(AVGDisplayableHolder.IPositionFeature feature, Command command, out Tween featureTween)
		{
		}

		// Token: 0x0600BFD0 RID: 49104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD0")]
		[Address(RVA = "0x33DB620", Offset = "0x33DA220", VA = "0x1833DB620")]
		private static void _ApplyRotationFeature(AVGDisplayableHolder.IRotationFeature feature, Command command)
		{
		}

		// Token: 0x0600BFD1 RID: 49105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD1")]
		[Address(RVA = "0x33DB890", Offset = "0x33DA490", VA = "0x1833DB890")]
		private static void _ApplyScaleFeature(AVGDisplayableHolder.IScaleFeature feature, Command command, out Tween featureTween)
		{
		}

		// Token: 0x0600BFD2 RID: 49106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD2")]
		[Address(RVA = "0x33DA780", Offset = "0x33D9380", VA = "0x1833DA780")]
		private static void _ApplyFadeFeature(AVGDisplayableHolder.IFadeFeature feature, Command command, out Tween featureTween)
		{
		}

		// Token: 0x0600BFD3 RID: 49107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD3")]
		[Address(RVA = "0x33DA490", Offset = "0x33D9090", VA = "0x1833DA490")]
		private static void _ApplyEntryFeature(AVGDisplayableHolder.IEntryFeature feature, Command command, out Tween featureTween)
		{
		}

		// Token: 0x0600BFD4 RID: 49108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD4")]
		[Address(RVA = "0x33DBFB0", Offset = "0x33DABB0", VA = "0x1833DBFB0")]
		protected AVGDisplayableHolder()
		{
		}

		// Token: 0x0400C109 RID: 49417
		[Token(Token = "0x400C109")]
		[FieldOffset(Offset = "0x18")]
		private string m_contentName;

		// Token: 0x0400C10A RID: 49418
		[Token(Token = "0x400C10A")]
		[FieldOffset(Offset = "0x20")]
		private Sequence m_sequence;

		// Token: 0x0400C10C RID: 49420
		[Token(Token = "0x400C10C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_contentObject;

		// Token: 0x0400C10D RID: 49421
		[Token(Token = "0x400C10D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_contentObject;

		// Token: 0x0400C10E RID: 49422
		[Token(Token = "0x400C10E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Display;

		// Token: 0x0400C10F RID: 49423
		[Token(Token = "0x400C10F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400C110 RID: 49424
		[Token(Token = "0x400C110")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetCanvas;

		// Token: 0x0400C111 RID: 49425
		[Token(Token = "0x400C111")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadContentIfNeed;

		// Token: 0x0400C112 RID: 49426
		[Token(Token = "0x400C112")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ApplyFeatures;

		// Token: 0x0400C113 RID: 49427
		[Token(Token = "0x400C113")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AddTweenToList;

		// Token: 0x0400C114 RID: 49428
		[Token(Token = "0x400C114")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ApplyPositionFeature;

		// Token: 0x0400C115 RID: 49429
		[Token(Token = "0x400C115")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ApplyRotationFeature;

		// Token: 0x0400C116 RID: 49430
		[Token(Token = "0x400C116")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ApplyScaleFeature;

		// Token: 0x0400C117 RID: 49431
		[Token(Token = "0x400C117")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ApplyFadeFeature;

		// Token: 0x0400C118 RID: 49432
		[Token(Token = "0x400C118")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ApplyEntryFeature;

		// Token: 0x0400C119 RID: 49433
		[Token(Token = "0x400C119")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E43 RID: 7747
		[Token(Token = "0x2001E43")]
		public struct AVGDisplayParam
		{
			// Token: 0x0400C11A RID: 49434
			[Token(Token = "0x400C11A")]
			[FieldOffset(Offset = "0x0")]
			public AVGDisplayableType type;

			// Token: 0x0400C11B RID: 49435
			[Token(Token = "0x400C11B")]
			[FieldOffset(Offset = "0x8")]
			public string name;

			// Token: 0x0400C11C RID: 49436
			[Token(Token = "0x400C11C")]
			[FieldOffset(Offset = "0x10")]
			public AVGControllerSceneCanvas canvas;

			// Token: 0x0400C11D RID: 49437
			[Token(Token = "0x400C11D")]
			[FieldOffset(Offset = "0x14")]
			public int layer;
		}

		// Token: 0x02001E44 RID: 7748
		[Token(Token = "0x2001E44")]
		public interface IFeature : IHotfixable
		{
		}

		// Token: 0x02001E45 RID: 7749
		[Token(Token = "0x2001E45")]
		public interface IPositionFeature : AVGDisplayableHolder.IFeature, IHotfixable
		{
			// Token: 0x1700172D RID: 5933
			// (get) Token: 0x0600BFD5 RID: 49109
			[Token(Token = "0x1700172D")]
			Transform contentTransform { [Token(Token = "0x600BFD5")] get; }
		}

		// Token: 0x02001E46 RID: 7750
		[Token(Token = "0x2001E46")]
		public interface IRotationFeature : AVGDisplayableHolder.IFeature, IHotfixable
		{
			// Token: 0x1700172E RID: 5934
			// (get) Token: 0x0600BFD6 RID: 49110
			[Token(Token = "0x1700172E")]
			Transform contentTransform { [Token(Token = "0x600BFD6")] get; }
		}

		// Token: 0x02001E47 RID: 7751
		[Token(Token = "0x2001E47")]
		public interface IScaleFeature : AVGDisplayableHolder.IFeature, IHotfixable
		{
			// Token: 0x1700172F RID: 5935
			// (get) Token: 0x0600BFD7 RID: 49111
			[Token(Token = "0x1700172F")]
			Transform contentTransform { [Token(Token = "0x600BFD7")] get; }
		}

		// Token: 0x02001E48 RID: 7752
		[Token(Token = "0x2001E48")]
		public interface IFadeFeature : AVGDisplayableHolder.IFeature, IHotfixable
		{
			// Token: 0x17001730 RID: 5936
			// (get) Token: 0x0600BFD8 RID: 49112
			[Token(Token = "0x17001730")]
			CanvasGroup contentGroup { [Token(Token = "0x600BFD8")] get; }

			// Token: 0x0400C11E RID: 49438
			[Token(Token = "0x400C11E")]
			public const float DEFAULT_DURATION = 0.1f;
		}

		// Token: 0x02001E49 RID: 7753
		[Token(Token = "0x2001E49")]
		public interface IEntryFeature : AVGDisplayableHolder.IFeature, IHotfixable
		{
			// Token: 0x0600BFD9 RID: 49113
			[Token(Token = "0x600BFD9")]
			Tween PlayEntry(float from, float to, float duration);
		}
	}
}
