using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine.Pool;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x5A40480", Offset = "0x5A3F080", VA = "0x185A40480")]
		public StylePropertyAnimationSystem()
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60003EA")]
		private T GetOrCreate<T>(ref T values) where T : new()
		{
			return null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x60003EB")]
		private bool StartTransition<T>(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, StylePropertyAnimationSystem.Values<T> values)
		{
			return default(bool);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x5A3FF50", Offset = "0x5A3EB50", VA = "0x185A3FF50", Slot = "4")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x5A3FC80", Offset = "0x5A3E880", VA = "0x185A3FC80", Slot = "5")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x5A3F9D0", Offset = "0x5A3E5D0", VA = "0x185A3F9D0", Slot = "6")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x5A3FAA0", Offset = "0x5A3E6A0", VA = "0x185A3FAA0", Slot = "7")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x5A3F7F0", Offset = "0x5A3E3F0", VA = "0x185A3F7F0", Slot = "8")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x5A3F8F0", Offset = "0x5A3E4F0", VA = "0x185A3F8F0", Slot = "9")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x5A40100", Offset = "0x5A3ED00", VA = "0x185A40100", Slot = "10")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x5A3FE40", Offset = "0x5A3EA40", VA = "0x185A3FE40", Slot = "11")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x5A40020", Offset = "0x5A3EC20", VA = "0x185A40020", Slot = "12")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x5A3FD40", Offset = "0x5A3E940", VA = "0x185A3FD40", Slot = "15")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x5A401D0", Offset = "0x5A3EDD0", VA = "0x185A401D0", Slot = "14")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x5A3FB80", Offset = "0x5A3E780", VA = "0x185A3FB80", Slot = "13")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x5A3F2E0", Offset = "0x5A3DEE0", VA = "0x185A3F2E0", Slot = "16")]
		public void CancelAllAnimations()
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x5A3F410", Offset = "0x5A3E010", VA = "0x185A3F410", Slot = "17")]
		public void CancelAllAnimations(VisualElement owner)
		{
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x5A3F5E0", Offset = "0x5A3E1E0", VA = "0x185A3F5E0", Slot = "18")]
		public void CancelAnimation(VisualElement owner, StylePropertyId id)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x5A402D0", Offset = "0x5A3EED0", VA = "0x185A402D0", Slot = "19")]
		public void UpdateAnimation(VisualElement owner, StylePropertyId id)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x5A3F690", Offset = "0x5A3E290", VA = "0x185A3F690", Slot = "20")]
		public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FD")]
		private void UpdateTracking<T>(StylePropertyAnimationSystem.Values<T> values)
		{
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
		private long CurrentTimeMs()
		{
			return 0L;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x5A40380", Offset = "0x5A3EF80", VA = "0x185A40380", Slot = "21")]
		public void Update()
		{
		}

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x10")]
		private long m_CurrentTimeMs;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x18")]
		private StylePropertyAnimationSystem.ValuesFloat m_Floats;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x20")]
		private StylePropertyAnimationSystem.ValuesInt m_Ints;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x28")]
		private StylePropertyAnimationSystem.ValuesLength m_Lengths;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x30")]
		private StylePropertyAnimationSystem.ValuesColor m_Colors;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x38")]
		private StylePropertyAnimationSystem.ValuesBackground m_Backgrounds;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x40")]
		private StylePropertyAnimationSystem.ValuesFontDefinition m_FontDefinitions;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x48")]
		private StylePropertyAnimationSystem.ValuesFont m_Fonts;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x50")]
		private StylePropertyAnimationSystem.ValuesTextShadow m_TextShadows;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x58")]
		private StylePropertyAnimationSystem.ValuesScale m_Scale;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x60")]
		private StylePropertyAnimationSystem.ValuesRotate m_Rotate;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x68")]
		private StylePropertyAnimationSystem.ValuesTranslate m_Translate;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x70")]
		private StylePropertyAnimationSystem.ValuesTransformOrigin m_TransformOrigin;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x78")]
		private readonly List<StylePropertyAnimationSystem.Values> m_AllValues;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x80")]
		private readonly Dictionary<StylePropertyId, StylePropertyAnimationSystem.Values> m_PropertyToValues;

		// Token: 0x02000081 RID: 129
		[Token(Token = "0x2000081")]
		[Flags]
		private enum TransitionState
		{
			// Token: 0x040001FD RID: 509
			[Token(Token = "0x40001FD")]
			None = 0,
			// Token: 0x040001FE RID: 510
			[Token(Token = "0x40001FE")]
			Running = 1,
			// Token: 0x040001FF RID: 511
			[Token(Token = "0x40001FF")]
			Started = 2,
			// Token: 0x04000200 RID: 512
			[Token(Token = "0x4000200")]
			Ended = 4,
			// Token: 0x04000201 RID: 513
			[Token(Token = "0x4000201")]
			Canceled = 8
		}

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x2000082")]
		private struct AnimationDataSet<TTimingData, TStyleData>
		{
			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x00003E10 File Offset: 0x00002010
			// (set) Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000113")]
			private int capacity
			{
				[Token(Token = "0x6000400")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000401")]
				set
				{
				}
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000402")]
			private void LocalInit()
			{
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x00003E28 File Offset: 0x00002028
			[Token(Token = "0x6000403")]
			public static StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData> Create()
			{
				return default(StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>);
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x00003E40 File Offset: 0x00002040
			[Token(Token = "0x6000404")]
			public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index)
			{
				return default(bool);
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000405")]
			public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData)
			{
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000406")]
			public void Remove(int cancelledIndex)
			{
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000407")]
			public void Replace(int index, TTimingData timingData, TStyleData styleData)
			{
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000408")]
			public void RemoveAll(VisualElement ve)
			{
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000409")]
			public void RemoveAll()
			{
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600040A")]
			public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties)
			{
			}

			// Token: 0x04000202 RID: 514
			[Token(Token = "0x4000202")]
			[FieldOffset(Offset = "0x0")]
			public VisualElement[] elements;

			// Token: 0x04000203 RID: 515
			[Token(Token = "0x4000203")]
			[FieldOffset(Offset = "0x0")]
			public StylePropertyId[] properties;

			// Token: 0x04000204 RID: 516
			[Token(Token = "0x4000204")]
			[FieldOffset(Offset = "0x0")]
			public TTimingData[] timing;

			// Token: 0x04000205 RID: 517
			[Token(Token = "0x4000205")]
			[FieldOffset(Offset = "0x0")]
			public TStyleData[] style;

			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000206")]
			[FieldOffset(Offset = "0x0")]
			public int count;

			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000207")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int> indices;
		}

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		private struct ElementPropertyPair
		{
			// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x21178B0", Offset = "0x21164B0", VA = "0x1821178B0")]
			public ElementPropertyPair(VisualElement element, StylePropertyId property)
			{
			}

			// Token: 0x04000208 RID: 520
			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x0")]
			public static readonly IEqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair> Comparer;

			// Token: 0x04000209 RID: 521
			[Token(Token = "0x4000209")]
			[FieldOffset(Offset = "0x0")]
			public readonly VisualElement element;

			// Token: 0x0400020A RID: 522
			[Token(Token = "0x400020A")]
			[FieldOffset(Offset = "0x8")]
			public readonly StylePropertyId property;

			// Token: 0x02000084 RID: 132
			[Token(Token = "0x2000084")]
			private class EqualityComparer : IEqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair>
			{
				// Token: 0x0600040D RID: 1037 RVA: 0x00003E58 File Offset: 0x00002058
				[Token(Token = "0x600040D")]
				[Address(RVA = "0x5A3D9A0", Offset = "0x5A3C5A0", VA = "0x185A3D9A0", Slot = "4")]
				public bool Equals(StylePropertyAnimationSystem.ElementPropertyPair x, StylePropertyAnimationSystem.ElementPropertyPair y)
				{
					return default(bool);
				}

				// Token: 0x0600040E RID: 1038 RVA: 0x00003E70 File Offset: 0x00002070
				[Token(Token = "0x600040E")]
				[Address(RVA = "0x5A3D9C0", Offset = "0x5A3C5C0", VA = "0x185A3D9C0", Slot = "5")]
				public int GetHashCode(StylePropertyAnimationSystem.ElementPropertyPair obj)
				{
					return 0;
				}

				// Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600040F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public EqualityComparer()
				{
				}
			}
		}

		// Token: 0x02000085 RID: 133
		[Token(Token = "0x2000085")]
		private abstract class Values
		{
			// Token: 0x06000410 RID: 1040
			[Token(Token = "0x6000410")]
			public abstract void CancelAllAnimations();

			// Token: 0x06000411 RID: 1041
			[Token(Token = "0x6000411")]
			public abstract void CancelAllAnimations(VisualElement ve);

			// Token: 0x06000412 RID: 1042
			[Token(Token = "0x6000412")]
			public abstract void CancelAnimation(VisualElement ve, StylePropertyId id);

			// Token: 0x06000413 RID: 1043
			[Token(Token = "0x6000413")]
			public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id);

			// Token: 0x06000414 RID: 1044
			[Token(Token = "0x6000414")]
			public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds);

			// Token: 0x06000415 RID: 1045
			[Token(Token = "0x6000415")]
			public abstract void Update(long currentTimeMs);

			// Token: 0x06000416 RID: 1046
			[Token(Token = "0x6000416")]
			protected abstract void UpdateValues();

			// Token: 0x06000417 RID: 1047
			[Token(Token = "0x6000417")]
			protected abstract void UpdateComputedStyle();

			// Token: 0x06000418 RID: 1048
			[Token(Token = "0x6000418")]
			protected abstract void UpdateComputedStyle(int i);

			// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected Values()
			{
			}
		}

		// Token: 0x02000086 RID: 134
		[Token(Token = "0x2000086")]
		private abstract class Values<T> : StylePropertyAnimationSystem.Values
		{
			// Token: 0x17000114 RID: 276
			// (get) Token: 0x0600041A RID: 1050 RVA: 0x00003E88 File Offset: 0x00002088
			[Token(Token = "0x17000114")]
			public bool isEmpty
			{
				[Token(Token = "0x600041A")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x0600041B RID: 1051
			[Token(Token = "0x17000115")]
			public abstract Func<T, T, bool> SameFunc { [Token(Token = "0x600041B")] get; }

			// Token: 0x0600041C RID: 1052 RVA: 0x00003EA0 File Offset: 0x000020A0
			[Token(Token = "0x600041C")]
			protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref T a, ref T b)
			{
				return default(bool);
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600041D")]
			protected Values()
			{
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600041E")]
			private void SwapFrameStates()
			{
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600041F")]
			private void QueueEvent(EventBase evt, StylePropertyAnimationSystem.ElementPropertyPair epp)
			{
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000420")]
			private void ClearEventQueue(StylePropertyAnimationSystem.ElementPropertyPair epp)
			{
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000421")]
			private void QueueTransitionRunEvent(VisualElement ve, int runningIndex)
			{
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000422")]
			private void QueueTransitionStartEvent(VisualElement ve, int runningIndex)
			{
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000423")]
			private void QueueTransitionEndEvent(VisualElement ve, int runningIndex)
			{
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000424")]
			private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs)
			{
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000425")]
			private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs)
			{
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000426")]
			public sealed override void CancelAllAnimations()
			{
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000427")]
			public sealed override void CancelAllAnimations(VisualElement ve)
			{
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000428")]
			public sealed override void CancelAnimation(VisualElement ve, StylePropertyId id)
			{
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000429")]
			public sealed override void UpdateAnimation(VisualElement ve, StylePropertyId id)
			{
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600042A")]
			public sealed override void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds)
			{
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x00003EB8 File Offset: 0x000020B8
			[Token(Token = "0x600042B")]
			private float ComputeReversingShorteningFactor(int oldIndex)
			{
				return 0f;
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x00003ED0 File Offset: 0x000020D0
			[Token(Token = "0x600042C")]
			private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor)
			{
				return 0;
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x00003EE8 File Offset: 0x000020E8
			[Token(Token = "0x600042D")]
			private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor)
			{
				return 0;
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x00003F00 File Offset: 0x00002100
			[Token(Token = "0x600042E")]
			public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, long currentTimeMs)
			{
				return default(bool);
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600042F")]
			private void ForceComputedStyleEndValue(int runningIndex)
			{
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000430")]
			public sealed override void Update(long currentTimeMs)
			{
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000431")]
			private void ProcessEventQueue()
			{
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000432")]
			private void UpdateProgress(long currentTimeMs)
			{
			}

			// Token: 0x0400020B RID: 523
			[Token(Token = "0x400020B")]
			[FieldOffset(Offset = "0x0")]
			private long m_CurrentTimeMs;

			// Token: 0x0400020C RID: 524
			[Token(Token = "0x400020C")]
			[FieldOffset(Offset = "0x0")]
			private StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState m_CurrentFrameEventsState;

			// Token: 0x0400020D RID: 525
			[Token(Token = "0x400020D")]
			[FieldOffset(Offset = "0x0")]
			private StylePropertyAnimationSystem.Values<T>.TransitionEventsFrameState m_NextFrameEventsState;

			// Token: 0x0400020E RID: 526
			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0x0")]
			public StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.TimingData, StylePropertyAnimationSystem.Values<T>.StyleData> running;

			// Token: 0x0400020F RID: 527
			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x0")]
			public StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values<T>.EmptyData, T> completed;

			// Token: 0x02000087 RID: 135
			[Token(Token = "0x2000087")]
			private class TransitionEventsFrameState
			{
				// Token: 0x06000433 RID: 1075 RVA: 0x0000212A File Offset: 0x0000032A
				[Token(Token = "0x6000433")]
				public static Queue<EventBase> GetPooledQueue()
				{
					return null;
				}

				// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000434")]
				public void RegisterChange()
				{
				}

				// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000435")]
				public void UnregisterChange()
				{
				}

				// Token: 0x06000436 RID: 1078 RVA: 0x00003F18 File Offset: 0x00002118
				[Token(Token = "0x6000436")]
				public bool StateChanged()
				{
					return default(bool);
				}

				// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000437")]
				public void Clear()
				{
				}

				// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000438")]
				public TransitionEventsFrameState()
				{
				}

				// Token: 0x04000210 RID: 528
				[Token(Token = "0x4000210")]
				[FieldOffset(Offset = "0x0")]
				private static readonly ObjectPool<Queue<EventBase>> k_EventQueuePool;

				// Token: 0x04000211 RID: 529
				[Token(Token = "0x4000211")]
				[FieldOffset(Offset = "0x0")]
				public readonly Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, StylePropertyAnimationSystem.TransitionState> elementPropertyStateDelta;

				// Token: 0x04000212 RID: 530
				[Token(Token = "0x4000212")]
				[FieldOffset(Offset = "0x0")]
				public readonly Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Queue<EventBase>> elementPropertyQueuedEvents;

				// Token: 0x04000213 RID: 531
				[Token(Token = "0x4000213")]
				[FieldOffset(Offset = "0x0")]
				public IPanel panel;

				// Token: 0x04000214 RID: 532
				[Token(Token = "0x4000214")]
				[FieldOffset(Offset = "0x0")]
				private int m_ChangesCount;
			}

			// Token: 0x02000089 RID: 137
			[Token(Token = "0x2000089")]
			public struct TimingData
			{
				// Token: 0x04000216 RID: 534
				[Token(Token = "0x4000216")]
				[FieldOffset(Offset = "0x0")]
				public long startTimeMs;

				// Token: 0x04000217 RID: 535
				[Token(Token = "0x4000217")]
				[FieldOffset(Offset = "0x0")]
				public int durationMs;

				// Token: 0x04000218 RID: 536
				[Token(Token = "0x4000218")]
				[FieldOffset(Offset = "0x0")]
				public Func<float, float> easingCurve;

				// Token: 0x04000219 RID: 537
				[Token(Token = "0x4000219")]
				[FieldOffset(Offset = "0x0")]
				public float easedProgress;

				// Token: 0x0400021A RID: 538
				[Token(Token = "0x400021A")]
				[FieldOffset(Offset = "0x0")]
				public float reversingShorteningFactor;

				// Token: 0x0400021B RID: 539
				[Token(Token = "0x400021B")]
				[FieldOffset(Offset = "0x0")]
				public bool isStarted;

				// Token: 0x0400021C RID: 540
				[Token(Token = "0x400021C")]
				[FieldOffset(Offset = "0x0")]
				public int delayMs;
			}

			// Token: 0x0200008A RID: 138
			[Token(Token = "0x200008A")]
			public struct StyleData
			{
				// Token: 0x0400021D RID: 541
				[Token(Token = "0x400021D")]
				[FieldOffset(Offset = "0x0")]
				public T startValue;

				// Token: 0x0400021E RID: 542
				[Token(Token = "0x400021E")]
				[FieldOffset(Offset = "0x0")]
				public T endValue;

				// Token: 0x0400021F RID: 543
				[Token(Token = "0x400021F")]
				[FieldOffset(Offset = "0x0")]
				public T reversingAdjustedStartValue;

				// Token: 0x04000220 RID: 544
				[Token(Token = "0x4000220")]
				[FieldOffset(Offset = "0x0")]
				public T currentValue;
			}

			// Token: 0x0200008B RID: 139
			[Token(Token = "0x200008B")]
			public struct EmptyData
			{
				// Token: 0x04000221 RID: 545
				[Token(Token = "0x4000221")]
				[FieldOffset(Offset = "0x0")]
				public static StylePropertyAnimationSystem.Values<T>.EmptyData Default;
			}
		}

		// Token: 0x0200008C RID: 140
		[Token(Token = "0x200008C")]
		private class ValuesFloat : StylePropertyAnimationSystem.Values<float>
		{
			// Token: 0x17000116 RID: 278
			// (get) Token: 0x0600043E RID: 1086 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000116")]
			public override Func<float, float, bool> SameFunc
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00003F30 File Offset: 0x00002130
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x5A42280", Offset = "0x5A40E80", VA = "0x185A42280")]
			private static bool IsSame(float a, float b)
			{
				return default(bool);
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x00003F48 File Offset: 0x00002148
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x594C060", Offset = "0x594AC60", VA = "0x18594C060")]
			private static float Lerp(float a, float b, float t)
			{
				return 0f;
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x5A423C0", Offset = "0x5A40FC0", VA = "0x185A423C0", Slot = "10")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x5A42290", Offset = "0x5A40E90", VA = "0x185A42290", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x5A42340", Offset = "0x5A40F40", VA = "0x185A42340", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x5A42440", Offset = "0x5A41040", VA = "0x185A42440")]
			public ValuesFloat()
			{
			}
		}

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		private class ValuesInt : StylePropertyAnimationSystem.Values<int>
		{
			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000445 RID: 1093 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000117")]
			public override Func<int, int, bool> SameFunc
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x00003F60 File Offset: 0x00002160
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
			private static bool IsSame(int a, int b)
			{
				return default(bool);
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x00003F78 File Offset: 0x00002178
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x5A9BB00", Offset = "0x5A9A700", VA = "0x185A9BB00")]
			private static int Lerp(int a, int b, float t)
			{
				return 0;
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x5A9BDA0", Offset = "0x5A9A9A0", VA = "0x185A9BDA0", Slot = "10")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x5A9BCC0", Offset = "0x5A9A8C0", VA = "0x185A9BCC0", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x5A9BC10", Offset = "0x5A9A810", VA = "0x185A9BC10", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x5A9BF60", Offset = "0x5A9AB60", VA = "0x185A9BF60")]
			public ValuesInt()
			{
			}
		}

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x200008E")]
		private class ValuesLength : StylePropertyAnimationSystem.Values<Length>
		{
			// Token: 0x17000118 RID: 280
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000118")]
			public override Func<Length, Length, bool> SameFunc
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x00003F90 File Offset: 0x00002190
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x5A9C040", Offset = "0x5A9AC40", VA = "0x185A9C040")]
			private static bool IsSame(Length a, Length b)
			{
				return default(bool);
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x00003FA8 File Offset: 0x000021A8
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x5A9C000", Offset = "0x5A9AC00", VA = "0x185A9C000", Slot = "14")]
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b)
			{
				return default(bool);
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00003FC0 File Offset: 0x000021C0
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x5A9C080", Offset = "0x5A9AC80", VA = "0x185A9C080")]
			internal static Length Lerp(Length a, Length b, float t)
			{
				return default(Length);
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x5A9C260", Offset = "0x5A9AE60", VA = "0x185A9C260", Slot = "10")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x5A9C0D0", Offset = "0x5A9ACD0", VA = "0x185A9C0D0", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x5A9C1B0", Offset = "0x5A9ADB0", VA = "0x185A9C1B0", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x5A9C330", Offset = "0x5A9AF30", VA = "0x185A9C330")]
			public ValuesLength()
			{
			}
		}

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		private class ValuesColor : StylePropertyAnimationSystem.Values<Color>
		{
			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000119")]
			public override Func<Color, Color, bool> SameFunc
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000455 RID: 1109 RVA: 0x00003FD8 File Offset: 0x000021D8
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x5A9B2C0", Offset = "0x5A99EC0", VA = "0x185A9B2C0")]
			private static bool IsSame(Color c, Color d)
			{
				return default(bool);
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x00003FF0 File Offset: 0x000021F0
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x5A9B340", Offset = "0x5A99F40", VA = "0x185A9B340")]
			private static Color Lerp(Color a, Color b, float t)
			{
				return default(Color);
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x5A9B590", Offset = "0x5A9A190", VA = "0x185A9B590", Slot = "10")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x5A9B4A0", Offset = "0x5A9A0A0", VA = "0x185A9B4A0", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x5A9B3E0", Offset = "0x5A99FE0", VA = "0x185A9B3E0", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x5A9B6A0", Offset = "0x5A9A2A0", VA = "0x185A9B6A0")]
			public ValuesColor()
			{
			}
		}

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x2000090")]
		private abstract class ValuesDiscrete<T> : StylePropertyAnimationSystem.Values<T>
		{
			// Token: 0x1700011A RID: 282
			// (get) Token: 0x0600045B RID: 1115 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x1700011A")]
			public override Func<T, T, bool> SameFunc
			{
				[Token(Token = "0x600045B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x00004008 File Offset: 0x00002208
			[Token(Token = "0x600045C")]
			private static bool IsSame(T a, T b)
			{
				return default(bool);
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x600045D")]
			private static T Lerp(T a, T b, float t)
			{
				return null;
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045E")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045F")]
			protected ValuesDiscrete()
			{
			}
		}

		// Token: 0x02000091 RID: 145
		[Token(Token = "0x2000091")]
		private class ValuesBackground : StylePropertyAnimationSystem.ValuesDiscrete<Background>
		{
			// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x5A9B180", Offset = "0x5A99D80", VA = "0x185A9B180", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x5A9B0C0", Offset = "0x5A99CC0", VA = "0x185A9B0C0", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x5A9B280", Offset = "0x5A99E80", VA = "0x185A9B280")]
			public ValuesBackground()
			{
			}
		}

		// Token: 0x02000092 RID: 146
		[Token(Token = "0x2000092")]
		private class ValuesFontDefinition : StylePropertyAnimationSystem.ValuesDiscrete<FontDefinition>
		{
			// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x5A9B800", Offset = "0x5A9A400", VA = "0x185A9B800", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x5A9B740", Offset = "0x5A9A340", VA = "0x185A9B740", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x5A9B8F0", Offset = "0x5A9A4F0", VA = "0x185A9B8F0")]
			public ValuesFontDefinition()
			{
			}
		}

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		private class ValuesFont : StylePropertyAnimationSystem.ValuesDiscrete<Font>
		{
			// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x5A9B9E0", Offset = "0x5A9A5E0", VA = "0x185A9B9E0", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x5A9B930", Offset = "0x5A9A530", VA = "0x185A9B930", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x5A9BAC0", Offset = "0x5A9A6C0", VA = "0x185A9BAC0")]
			public ValuesFont()
			{
			}
		}

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		private class ValuesTextShadow : StylePropertyAnimationSystem.Values<TextShadow>
		{
			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x1700011B")]
			public override Func<TextShadow, TextShadow, bool> SameFunc
			{
				[Token(Token = "0x6000469")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x00004020 File Offset: 0x00002220
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x5A9CCD0", Offset = "0x5A9B8D0", VA = "0x185A9CCD0")]
			private static bool IsSame(TextShadow a, TextShadow b)
			{
				return default(bool);
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x00004038 File Offset: 0x00002238
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x5A9CDA0", Offset = "0x5A9B9A0", VA = "0x185A9CDA0")]
			private static TextShadow Lerp(TextShadow a, TextShadow b, float t)
			{
				return default(TextShadow);
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x5A9D0F0", Offset = "0x5A9BCF0", VA = "0x185A9D0F0", Slot = "10")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x5A9CFD0", Offset = "0x5A9BBD0", VA = "0x185A9CFD0", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x5A9CEF0", Offset = "0x5A9BAF0", VA = "0x185A9CEF0", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x5A9D2B0", Offset = "0x5A9BEB0", VA = "0x185A9D2B0")]
			public ValuesTextShadow()
			{
			}
		}

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		private class ValuesScale : StylePropertyAnimationSystem.Values<Scale>
		{
			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x1700011C")]
			public override Func<Scale, Scale, bool> SameFunc
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00004050 File Offset: 0x00002250
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x5A9C880", Offset = "0x5A9B480", VA = "0x185A9C880")]
			private static bool IsSame(Scale a, Scale b)
			{
				return default(bool);
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x5A9CA10", Offset = "0x5A9B610", VA = "0x185A9CA10", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x5A9C950", Offset = "0x5A9B550", VA = "0x185A9C950", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x06000474 RID: 1140 RVA: 0x00004068 File Offset: 0x00002268
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x5A9C8B0", Offset = "0x5A9B4B0", VA = "0x185A9C8B0")]
			private static Scale Lerp(Scale a, Scale b, float t)
			{
				return default(Scale);
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x5A9CB00", Offset = "0x5A9B700", VA = "0x185A9CB00", Slot = "10")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x5A9CC30", Offset = "0x5A9B830", VA = "0x185A9CC30")]
			public ValuesScale()
			{
			}
		}

		// Token: 0x02000096 RID: 150
		[Token(Token = "0x2000096")]
		private class ValuesRotate : StylePropertyAnimationSystem.Values<Rotate>
		{
			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x1700011D")]
			public override Func<Rotate, Rotate, bool> SameFunc
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x00004080 File Offset: 0x00002280
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x5A9C3D0", Offset = "0x5A9AFD0", VA = "0x185A9C3D0")]
			private static bool IsSame(Rotate a, Rotate b)
			{
				return default(bool);
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x5A9C580", Offset = "0x5A9B180", VA = "0x185A9C580", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x5A9C4B0", Offset = "0x5A9B0B0", VA = "0x185A9C4B0", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x00004098 File Offset: 0x00002298
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x5A9C420", Offset = "0x5A9B020", VA = "0x185A9C420")]
			private static Rotate Lerp(Rotate a, Rotate b, float t)
			{
				return default(Rotate);
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x5A9C690", Offset = "0x5A9B290", VA = "0x185A9C690", Slot = "10")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x5A9C7E0", Offset = "0x5A9B3E0", VA = "0x185A9C7E0")]
			public ValuesRotate()
			{
			}
		}

		// Token: 0x02000097 RID: 151
		[Token(Token = "0x2000097")]
		private class ValuesTranslate : StylePropertyAnimationSystem.Values<Translate>
		{
			// Token: 0x1700011E RID: 286
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x1700011E")]
			public override Func<Translate, Translate, bool> SameFunc
			{
				[Token(Token = "0x600047E")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x000040B0 File Offset: 0x000022B0
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x5A9D9B0", Offset = "0x5A9C5B0", VA = "0x185A9D9B0")]
			private static bool IsSame(Translate a, Translate b)
			{
				return default(bool);
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x000040C8 File Offset: 0x000022C8
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x5A9D980", Offset = "0x5A9C580", VA = "0x185A9D980", Slot = "14")]
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b)
			{
				return default(bool);
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x5A9DBF0", Offset = "0x5A9C7F0", VA = "0x185A9DBF0", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x5A9DB20", Offset = "0x5A9C720", VA = "0x185A9DB20", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x000040E0 File Offset: 0x000022E0
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x5A9DA00", Offset = "0x5A9C600", VA = "0x185A9DA00")]
			private static Translate Lerp(Translate a, Translate b, float t)
			{
				return default(Translate);
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x5A9DD00", Offset = "0x5A9C900", VA = "0x185A9DD00", Slot = "10")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x5A9DF40", Offset = "0x5A9CB40", VA = "0x185A9DF40")]
			public ValuesTranslate()
			{
			}
		}

		// Token: 0x02000098 RID: 152
		[Token(Token = "0x2000098")]
		private class ValuesTransformOrigin : StylePropertyAnimationSystem.Values<TransformOrigin>
		{
			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000486 RID: 1158 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x1700011F")]
			public override Func<TransformOrigin, TransformOrigin, bool> SameFunc
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x000040F8 File Offset: 0x000022F8
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x5A9D380", Offset = "0x5A9BF80", VA = "0x185A9D380")]
			private static bool IsSame(TransformOrigin a, TransformOrigin b)
			{
				return default(bool);
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x00004110 File Offset: 0x00002310
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x5A9D350", Offset = "0x5A9BF50", VA = "0x185A9D350", Slot = "14")]
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b)
			{
				return default(bool);
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x5A9D5A0", Offset = "0x5A9C1A0", VA = "0x185A9D5A0", Slot = "11")]
			protected sealed override void UpdateComputedStyle()
			{
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x5A9D4E0", Offset = "0x5A9C0E0", VA = "0x185A9D4E0", Slot = "12")]
			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x00004128 File Offset: 0x00002328
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x5A9D3C0", Offset = "0x5A9BFC0", VA = "0x185A9D3C0")]
			private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t)
			{
				return default(TransformOrigin);
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x5A9D6A0", Offset = "0x5A9C2A0", VA = "0x185A9D6A0", Slot = "10")]
			protected sealed override void UpdateValues()
			{
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x5A9D8E0", Offset = "0x5A9C4E0", VA = "0x185A9D8E0")]
			public ValuesTransformOrigin()
			{
			}
		}
	}
}
