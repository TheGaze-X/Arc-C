using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007C19 RID: 31769
	[Token(Token = "0x2007C19")]
	public class tk<T, TContext>
	{
		// Token: 0x0602C6DA RID: 181978 RVA: 0x000E00E8 File Offset: 0x000DE2E8
		[Token(Token = "0x602C6DA")]
		public static tk<T, TContext>.Value<TValue> Val<TValue>(tk<T, TContext>.Value<TValue>.GeneratorNoContext generator)
		{
			return default(tk<T, TContext>.Value<TValue>);
		}

		// Token: 0x0602C6DB RID: 181979 RVA: 0x000E0100 File Offset: 0x000DE300
		[Token(Token = "0x602C6DB")]
		public static tk<T, TContext>.Value<TValue> Val<TValue>(tk<T, TContext>.Value<TValue>.Generator generator)
		{
			return default(tk<T, TContext>.Value<TValue>);
		}

		// Token: 0x0602C6DC RID: 181980 RVA: 0x000E0118 File Offset: 0x000DE318
		[Token(Token = "0x602C6DC")]
		public static tk<T, TContext>.Value<TValue> Val<TValue>(TValue value)
		{
			return default(tk<T, TContext>.Value<TValue>);
		}

		// Token: 0x0602C6DD RID: 181981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C6DD")]
		public tk()
		{
		}

		// Token: 0x02007C1A RID: 31770
		[Token(Token = "0x2007C1A")]
		public class Box : tkControl<T, TContext>
		{
			// Token: 0x0602C6DE RID: 181982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6DE")]
			public Box(tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C6DF RID: 181983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C6DF")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C6E0 RID: 181984 RVA: 0x000E0130 File Offset: 0x000DE330
			[Token(Token = "0x602C6E0")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402B0 RID: 262832
			[Token(Token = "0x40402B0")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tkControl<T, TContext> _control;
		}

		// Token: 0x02007C1B RID: 31771
		[Token(Token = "0x2007C1B")]
		public class Button : tkControl<T, TContext>
		{
			// Token: 0x0602C6E1 RID: 181985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6E1")]
			public Button(string methodName)
			{
			}

			// Token: 0x0602C6E2 RID: 181986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6E2")]
			public Button(tk<T, TContext>.Value<fiGUIContent> label, Action<T, TContext> onClick)
			{
			}

			// Token: 0x0602C6E3 RID: 181987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6E3")]
			public Button(fiGUIContent label, Action<T, TContext> onClick)
			{
			}

			// Token: 0x0602C6E4 RID: 181988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C6E4")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C6E5 RID: 181989 RVA: 0x000E0148 File Offset: 0x000DE348
			[Token(Token = "0x602C6E5")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402B1 RID: 262833
			[Token(Token = "0x40402B1")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tk<T, TContext>.Value<fiGUIContent> _label;

			// Token: 0x040402B2 RID: 262834
			[Token(Token = "0x40402B2")]
			[FieldOffset(Offset = "0x0")]
			private readonly bool _enabled;

			// Token: 0x040402B3 RID: 262835
			[Token(Token = "0x40402B3")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<T, TContext> _onClick;
		}

		// Token: 0x02007C1E RID: 31774
		[Token(Token = "0x2007C1E")]
		public class CenterVertical : tkControl<T, TContext>
		{
			// Token: 0x0602C6EB RID: 181995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6EB")]
			public CenterVertical(tkControl<T, TContext> centered)
			{
			}

			// Token: 0x0602C6EC RID: 181996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C6EC")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C6ED RID: 181997 RVA: 0x000E0160 File Offset: 0x000DE360
			[Token(Token = "0x602C6ED")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402B7 RID: 262839
			[Token(Token = "0x40402B7")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tkControl<T, TContext> _centered;
		}

		// Token: 0x02007C1F RID: 31775
		[Token(Token = "0x2007C1F")]
		public class Color : tk<T, TContext>.ColorIf
		{
			// Token: 0x0602C6EE RID: 181998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6EE")]
			public Color(tk<T, TContext>.Value<UnityEngine.Color> color)
			{
			}
		}

		// Token: 0x02007C21 RID: 31777
		[Token(Token = "0x2007C21")]
		public class ColorIf : tk<T, TContext>.ConditionalStyle
		{
			// Token: 0x0602C6F2 RID: 182002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6F2")]
			public ColorIf(tk<T, TContext>.Value<bool> shouldActivate, tk<T, TContext>.Value<UnityEngine.Color> color)
			{
			}

			// Token: 0x0602C6F3 RID: 182003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6F3")]
			public ColorIf(tk<T, TContext>.Value<bool>.Generator shouldActivate, tk<T, TContext>.Value<UnityEngine.Color> color)
			{
			}

			// Token: 0x0602C6F4 RID: 182004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6F4")]
			public ColorIf(tk<T, TContext>.Value<bool>.GeneratorNoContext shouldActivate, tk<T, TContext>.Value<UnityEngine.Color> color)
			{
			}
		}

		// Token: 0x02007C24 RID: 31780
		[Token(Token = "0x2007C24")]
		public class Comment : tkControl<T, TContext>
		{
			// Token: 0x0602C6FA RID: 182010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6FA")]
			public Comment(tk<T, TContext>.Value<string> comment, CommentType commentType)
			{
			}

			// Token: 0x0602C6FB RID: 182011 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C6FB")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C6FC RID: 182012 RVA: 0x000E0190 File Offset: 0x000DE390
			[Token(Token = "0x602C6FC")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402BD RID: 262845
			[Token(Token = "0x40402BD")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<string> _comment;

			// Token: 0x040402BE RID: 262846
			[Token(Token = "0x40402BE")]
			[FieldOffset(Offset = "0x0")]
			private readonly CommentType _commentType;
		}

		// Token: 0x02007C25 RID: 31781
		[Token(Token = "0x2007C25")]
		public class ConditionalStyle : tkStyle<T, TContext>
		{
			// Token: 0x0602C6FD RID: 182013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6FD")]
			public ConditionalStyle(Func<T, TContext, bool> shouldActivate, Func<T, TContext, object> activate, Action<T, TContext, object> deactivate)
			{
			}

			// Token: 0x0602C6FE RID: 182014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6FE")]
			public override void Activate(T obj, TContext context)
			{
			}

			// Token: 0x0602C6FF RID: 182015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C6FF")]
			public override void Deactivate(T obj, TContext context)
			{
			}

			// Token: 0x040402BF RID: 262847
			[Token(Token = "0x40402BF")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<T, TContext, bool> _shouldActivate;

			// Token: 0x040402C0 RID: 262848
			[Token(Token = "0x40402C0")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<T, TContext, object> _activate;

			// Token: 0x040402C1 RID: 262849
			[Token(Token = "0x40402C1")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<T, TContext, object> _deactivate;

			// Token: 0x040402C2 RID: 262850
			[Token(Token = "0x40402C2")]
			[FieldOffset(Offset = "0x0")]
			private readonly fiStackValue<bool> _activatedStack;

			// Token: 0x040402C3 RID: 262851
			[Token(Token = "0x40402C3")]
			[FieldOffset(Offset = "0x0")]
			private readonly fiStackValue<object> _activationStateStack;
		}

		// Token: 0x02007C26 RID: 31782
		[Token(Token = "0x2007C26")]
		public class Context : tkControl<T, TContext>
		{
			// Token: 0x0602C700 RID: 182016 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C700")]
			public tkControl<T, TContext> With(tkControl<T, TContext> control)
			{
				return null;
			}

			// Token: 0x17006810 RID: 26640
			// (get) Token: 0x0602C701 RID: 182017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17006810")]
			public T Data
			{
				[Token(Token = "0x602C701")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602C702 RID: 182018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C702")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C703 RID: 182019 RVA: 0x000E01A8 File Offset: 0x000DE3A8
			[Token(Token = "0x602C703")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x0602C704 RID: 182020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C704")]
			public Context()
			{
			}

			// Token: 0x040402C4 RID: 262852
			[Token(Token = "0x40402C4")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private tkControl<T, TContext> _control;

			// Token: 0x040402C5 RID: 262853
			[Token(Token = "0x40402C5")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly fiStackValue<T> _data;
		}

		// Token: 0x02007C27 RID: 31783
		[Token(Token = "0x2007C27")]
		public class DefaultInspector : tkControl<T, TContext>
		{
			// Token: 0x0602C705 RID: 182021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C705")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C706 RID: 182022 RVA: 0x000E01C0 File Offset: 0x000DE3C0
			[Token(Token = "0x602C706")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x0602C707 RID: 182023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C707")]
			public DefaultInspector()
			{
			}

			// Token: 0x040402C6 RID: 262854
			[Token(Token = "0x40402C6")]
			[FieldOffset(Offset = "0x0")]
			private readonly Type type_fitkControlPropertyEditor;

			// Token: 0x040402C7 RID: 262855
			[Token(Token = "0x40402C7")]
			[FieldOffset(Offset = "0x0")]
			private readonly Type type_IObjectPropertyEditor;
		}

		// Token: 0x02007C28 RID: 31784
		[Token(Token = "0x2007C28")]
		public class DisableHierarchyMode : tkControl<T, TContext>
		{
			// Token: 0x0602C708 RID: 182024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C708")]
			public DisableHierarchyMode(tkControl<T, TContext> childControl)
			{
			}

			// Token: 0x0602C709 RID: 182025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C709")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C70A RID: 182026 RVA: 0x000E01D8 File Offset: 0x000DE3D8
			[Token(Token = "0x602C70A")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402C8 RID: 262856
			[Token(Token = "0x40402C8")]
			[FieldOffset(Offset = "0x0")]
			private tkControl<T, TContext> _childControl;
		}

		// Token: 0x02007C29 RID: 31785
		[Token(Token = "0x2007C29")]
		public class Empty : tkControl<T, TContext>
		{
			// Token: 0x0602C70B RID: 182027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C70B")]
			public Empty()
			{
			}

			// Token: 0x0602C70C RID: 182028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C70C")]
			public Empty(tk<T, TContext>.Value<float> height)
			{
			}

			// Token: 0x0602C70D RID: 182029 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C70D")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C70E RID: 182030 RVA: 0x000E01F0 File Offset: 0x000DE3F0
			[Token(Token = "0x602C70E")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402C9 RID: 262857
			[Token(Token = "0x40402C9")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tk<T, TContext>.Value<float> _height;
		}

		// Token: 0x02007C2A RID: 31786
		[Token(Token = "0x2007C2A")]
		public class EnabledIf : tk<T, TContext>.ConditionalStyle
		{
			// Token: 0x0602C70F RID: 182031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C70F")]
			public EnabledIf(tk<T, TContext>.Value<bool> isEnabled)
			{
			}

			// Token: 0x0602C710 RID: 182032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C710")]
			public EnabledIf(tk<T, TContext>.Value<bool>.Generator isEnabled)
			{
			}

			// Token: 0x0602C711 RID: 182033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C711")]
			public EnabledIf(tk<T, TContext>.Value<bool>.GeneratorNoContext isEnabled)
			{
			}
		}

		// Token: 0x02007C2D RID: 31789
		[Token(Token = "0x2007C2D")]
		public class Foldout : tkControl<T, TContext>
		{
			// Token: 0x17006811 RID: 26641
			// (get) Token: 0x0602C718 RID: 182040 RVA: 0x000E0220 File Offset: 0x000DE420
			// (set) Token: 0x0602C719 RID: 182041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006811")]
			[ShowInInspector]
			public bool IndentChildControl
			{
				[Token(Token = "0x602C718")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602C719")]
				set
				{
				}
			}

			// Token: 0x0602C71A RID: 182042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C71A")]
			public Foldout(fiGUIContent label, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C71B RID: 182043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C71B")]
			public Foldout(fiGUIContent label, FontStyle fontStyle, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C71C RID: 182044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C71C")]
			public Foldout(fiGUIContent label, FontStyle fontStyle, bool defaultToExpanded, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C71D RID: 182045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C71D")]
			private tkFoldoutMetadata GetMetadata(fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C71E RID: 182046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C71E")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C71F RID: 182047 RVA: 0x000E0238 File Offset: 0x000DE438
			[Token(Token = "0x602C71F")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402CE RID: 262862
			[Token(Token = "0x40402CE")]
			[FieldOffset(Offset = "0x0")]
			private readonly GUIStyle _foldoutStyle;

			// Token: 0x040402CF RID: 262863
			[Token(Token = "0x40402CF")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly fiGUIContent _label;

			// Token: 0x040402D0 RID: 262864
			[Token(Token = "0x40402D0")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tkControl<T, TContext> _control;

			// Token: 0x040402D1 RID: 262865
			[Token(Token = "0x40402D1")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly bool _defaultToExpanded;

			// Token: 0x040402D2 RID: 262866
			[Token(Token = "0x40402D2")]
			[FieldOffset(Offset = "0x0")]
			private bool _doNotIndentChildControl;

			// Token: 0x040402D3 RID: 262867
			[Token(Token = "0x40402D3")]
			[FieldOffset(Offset = "0x0")]
			public bool? HierarchyMode;
		}

		// Token: 0x02007C2E RID: 31790
		[Token(Token = "0x2007C2E")]
		public class HorizontalGroup : tkControl<T, TContext>, IEnumerable
		{
			// Token: 0x17006812 RID: 26642
			// (get) Token: 0x0602C720 RID: 182048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17006812")]
			protected override IEnumerable<tkIControl> NonMemberChildControls
			{
				[Token(Token = "0x602C720")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602C721 RID: 182049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C721")]
			public void Add(tkControl<T, TContext> rule)
			{
			}

			// Token: 0x0602C722 RID: 182050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C722")]
			public void Add(bool matchParentHeight, tkControl<T, TContext> rule)
			{
			}

			// Token: 0x0602C723 RID: 182051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C723")]
			public void Add(float width)
			{
			}

			// Token: 0x0602C724 RID: 182052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C724")]
			public void Add(float width, tkControl<T, TContext> rule)
			{
			}

			// Token: 0x0602C725 RID: 182053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C725")]
			private void InternalAdd(bool matchParentHeight, float width, float fillStrength, tkControl<T, TContext> rule)
			{
			}

			// Token: 0x0602C726 RID: 182054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C726")]
			private void DoLayout(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
			}

			// Token: 0x0602C727 RID: 182055 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C727")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C728 RID: 182056 RVA: 0x000E0250 File Offset: 0x000DE450
			[Token(Token = "0x602C728")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x0602C729 RID: 182057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C729")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0602C72A RID: 182058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C72A")]
			public HorizontalGroup()
			{
			}

			// Token: 0x040402D4 RID: 262868
			[Token(Token = "0x40402D4")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly List<tk<T, TContext>.HorizontalGroup.SectionItem> _items;

			// Token: 0x040402D5 RID: 262869
			[Token(Token = "0x40402D5")]
			[FieldOffset(Offset = "0x0")]
			private static readonly tkControl<T, TContext> DefaultRule;

			// Token: 0x02007C2F RID: 31791
			[Token(Token = "0x2007C2F")]
			private struct SectionItem
			{
				// Token: 0x17006813 RID: 26643
				// (get) Token: 0x0602C72C RID: 182060 RVA: 0x000E0268 File Offset: 0x000DE468
				// (set) Token: 0x0602C72D RID: 182061 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17006813")]
				[ShowInInspector]
				public float MinWidth
				{
					[Token(Token = "0x602C72C")]
					get
					{
						return 0f;
					}
					[Token(Token = "0x602C72D")]
					set
					{
					}
				}

				// Token: 0x17006814 RID: 26644
				// (get) Token: 0x0602C72E RID: 182062 RVA: 0x000E0280 File Offset: 0x000DE480
				// (set) Token: 0x0602C72F RID: 182063 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17006814")]
				[ShowInInspector]
				public float FillStrength
				{
					[Token(Token = "0x602C72E")]
					get
					{
						return 0f;
					}
					[Token(Token = "0x602C72F")]
					set
					{
					}
				}

				// Token: 0x17006815 RID: 26645
				// (get) Token: 0x0602C730 RID: 182064 RVA: 0x000E0298 File Offset: 0x000DE498
				[Token(Token = "0x17006815")]
				public float Layout_Width
				{
					[Token(Token = "0x602C730")]
					get
					{
						return 0f;
					}
				}

				// Token: 0x040402D6 RID: 262870
				[Token(Token = "0x40402D6")]
				[FieldOffset(Offset = "0x0")]
				private float _minWidth;

				// Token: 0x040402D7 RID: 262871
				[Token(Token = "0x40402D7")]
				[FieldOffset(Offset = "0x0")]
				private float _fillStrength;

				// Token: 0x040402D8 RID: 262872
				[Token(Token = "0x40402D8")]
				[FieldOffset(Offset = "0x0")]
				public bool MatchParentHeight;

				// Token: 0x040402D9 RID: 262873
				[Token(Token = "0x40402D9")]
				[FieldOffset(Offset = "0x0")]
				public tkControl<T, TContext> Rule;

				// Token: 0x040402DA RID: 262874
				[Token(Token = "0x40402DA")]
				[FieldOffset(Offset = "0x0")]
				public bool Layout_IsFlexible;

				// Token: 0x040402DB RID: 262875
				[Token(Token = "0x40402DB")]
				[FieldOffset(Offset = "0x0")]
				public float Layout_FlexibleWidth;
			}
		}

		// Token: 0x02007C31 RID: 31793
		[Token(Token = "0x2007C31")]
		public class Indent : tkControl<T, TContext>
		{
			// Token: 0x0602C73A RID: 182074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C73A")]
			public Indent(tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C73B RID: 182075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C73B")]
			public Indent(tk<T, TContext>.Value<float> indent, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C73C RID: 182076 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C73C")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C73D RID: 182077 RVA: 0x000E02C8 File Offset: 0x000DE4C8
			[Token(Token = "0x602C73D")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402E1 RID: 262881
			[Token(Token = "0x40402E1")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tk<T, TContext>.Value<float> _indent;

			// Token: 0x040402E2 RID: 262882
			[Token(Token = "0x40402E2")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tkControl<T, TContext> _control;
		}

		// Token: 0x02007C32 RID: 31794
		[Token(Token = "0x2007C32")]
		public class IntSlider : tkControl<T, TContext>
		{
			// Token: 0x0602C73E RID: 182078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C73E")]
			public IntSlider(tk<T, TContext>.Value<int> min, tk<T, TContext>.Value<int> max, Func<T, TContext, int> getValue, Action<T, TContext, int> setValue)
			{
			}

			// Token: 0x0602C73F RID: 182079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C73F")]
			public IntSlider(tk<T, TContext>.Value<fiGUIContent> label, tk<T, TContext>.Value<int> min, tk<T, TContext>.Value<int> max, Func<T, TContext, int> getValue, Action<T, TContext, int> setValue)
			{
			}

			// Token: 0x0602C740 RID: 182080 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C740")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C741 RID: 182081 RVA: 0x000E02E0 File Offset: 0x000DE4E0
			[Token(Token = "0x602C741")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402E3 RID: 262883
			[Token(Token = "0x40402E3")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<int> _min;

			// Token: 0x040402E4 RID: 262884
			[Token(Token = "0x40402E4")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<int> _max;

			// Token: 0x040402E5 RID: 262885
			[Token(Token = "0x40402E5")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<T, TContext, int> _getValue;

			// Token: 0x040402E6 RID: 262886
			[Token(Token = "0x40402E6")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<T, TContext, int> _setValue;

			// Token: 0x040402E7 RID: 262887
			[Token(Token = "0x40402E7")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<fiGUIContent> _label;
		}

		// Token: 0x02007C33 RID: 31795
		[Token(Token = "0x2007C33")]
		public class Label : tkControl<T, TContext>
		{
			// Token: 0x0602C742 RID: 182082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C742")]
			public Label(fiGUIContent label)
			{
			}

			// Token: 0x0602C743 RID: 182083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C743")]
			public Label(tk<T, TContext>.Value<fiGUIContent> label)
			{
			}

			// Token: 0x0602C744 RID: 182084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C744")]
			public Label(tk<T, TContext>.Value<fiGUIContent>.Generator label)
			{
			}

			// Token: 0x0602C745 RID: 182085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C745")]
			public Label(fiGUIContent label, FontStyle fontStyle)
			{
			}

			// Token: 0x0602C746 RID: 182086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C746")]
			public Label(tk<T, TContext>.Value<fiGUIContent> label, FontStyle fontStyle)
			{
			}

			// Token: 0x0602C747 RID: 182087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C747")]
			public Label(tk<T, TContext>.Value<fiGUIContent>.Generator label, FontStyle fontStyle)
			{
			}

			// Token: 0x0602C748 RID: 182088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C748")]
			public Label(fiGUIContent label, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C749 RID: 182089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C749")]
			public Label(tk<T, TContext>.Value<fiGUIContent> label, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C74A RID: 182090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C74A")]
			public Label(tk<T, TContext>.Value<fiGUIContent>.Generator label, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C74B RID: 182091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C74B")]
			public Label(fiGUIContent label, FontStyle fontStyle, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C74C RID: 182092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C74C")]
			public Label(tk<T, TContext>.Value<fiGUIContent> label, FontStyle fontStyle, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C74D RID: 182093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C74D")]
			public Label(tk<T, TContext>.Value<fiGUIContent>.Generator label, FontStyle fontStyle, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C74E RID: 182094 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C74E")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C74F RID: 182095 RVA: 0x000E02F8 File Offset: 0x000DE4F8
			[Token(Token = "0x602C74F")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402E8 RID: 262888
			[Token(Token = "0x40402E8")]
			[FieldOffset(Offset = "0x0")]
			public tk<T, TContext>.Value<fiGUIContent> GUIContent;

			// Token: 0x040402E9 RID: 262889
			[Token(Token = "0x40402E9")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly FontStyle _fontStyle;

			// Token: 0x040402EA RID: 262890
			[Token(Token = "0x40402EA")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tkControl<T, TContext> _control;

			// Token: 0x040402EB RID: 262891
			[Token(Token = "0x40402EB")]
			[FieldOffset(Offset = "0x0")]
			public bool InlineControl;
		}

		// Token: 0x02007C34 RID: 31796
		[Token(Token = "0x2007C34")]
		public class Margin : tkControl<T, TContext>
		{
			// Token: 0x0602C750 RID: 182096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C750")]
			public Margin(tk<T, TContext>.Value<float> margin, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C751 RID: 182097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C751")]
			public Margin(tk<T, TContext>.Value<float> left, tk<T, TContext>.Value<float> top, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C752 RID: 182098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C752")]
			public Margin(tk<T, TContext>.Value<float> left, tk<T, TContext>.Value<float> top, tk<T, TContext>.Value<float> right, tk<T, TContext>.Value<float> bottom, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C753 RID: 182099 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C753")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C754 RID: 182100 RVA: 0x000E0310 File Offset: 0x000DE510
			[Token(Token = "0x602C754")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402EC RID: 262892
			[Token(Token = "0x40402EC")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tk<T, TContext>.Value<float> _left;

			// Token: 0x040402ED RID: 262893
			[Token(Token = "0x40402ED")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tk<T, TContext>.Value<float> _top;

			// Token: 0x040402EE RID: 262894
			[Token(Token = "0x40402EE")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tk<T, TContext>.Value<float> _right;

			// Token: 0x040402EF RID: 262895
			[Token(Token = "0x40402EF")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tk<T, TContext>.Value<float> _bottom;

			// Token: 0x040402F0 RID: 262896
			[Token(Token = "0x40402F0")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tkControl<T, TContext> _control;
		}

		// Token: 0x02007C35 RID: 31797
		[Token(Token = "0x2007C35")]
		public class Popup : tkControl<T, TContext>
		{
			// Token: 0x0602C755 RID: 182101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C755")]
			public Popup(tk<T, TContext>.Value<fiGUIContent> label, tk<T, TContext>.Value<GUIContent[]> options, tk<T, TContext>.Value<int> currentSelection, tk<T, TContext>.Popup.OnSelectionChanged onSelectionChanged)
			{
			}

			// Token: 0x0602C756 RID: 182102 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C756")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C757 RID: 182103 RVA: 0x000E0328 File Offset: 0x000DE528
			[Token(Token = "0x602C757")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402F1 RID: 262897
			[Token(Token = "0x40402F1")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<fiGUIContent> _label;

			// Token: 0x040402F2 RID: 262898
			[Token(Token = "0x40402F2")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<GUIContent[]> _options;

			// Token: 0x040402F3 RID: 262899
			[Token(Token = "0x40402F3")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<int> _currentSelection;

			// Token: 0x040402F4 RID: 262900
			[Token(Token = "0x40402F4")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Popup.OnSelectionChanged _onSelectionChanged;

			// Token: 0x02007C36 RID: 31798
			// (Invoke) Token: 0x0602C759 RID: 182105
			[Token(Token = "0x2007C36")]
			public delegate T OnSelectionChanged(T obj, TContext context, int selected);
		}

		// Token: 0x02007C37 RID: 31799
		[Token(Token = "0x2007C37")]
		public class PropertyEditor : tkControl<T, TContext>
		{
			// Token: 0x0602C75C RID: 182108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C75C")]
			private void InitializeFromMemberName(string memberName)
			{
			}

			// Token: 0x0602C75D RID: 182109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C75D")]
			public PropertyEditor(string memberName)
			{
			}

			// Token: 0x0602C75E RID: 182110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C75E")]
			public PropertyEditor(fiGUIContent label, string memberName)
			{
			}

			// Token: 0x0602C75F RID: 182111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C75F")]
			public PropertyEditor(tk<T, TContext>.Value<fiGUIContent> label, string memberName)
			{
			}

			// Token: 0x0602C760 RID: 182112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C760")]
			public PropertyEditor(fiGUIContent label, Type fieldType, MemberInfo attributes, Func<T, TContext, object> getValue, Action<T, TContext, object> setValue)
			{
			}

			// Token: 0x0602C761 RID: 182113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C761")]
			public static tk<T, TContext>.PropertyEditor Create<TEdited>(fiGUIContent label, MemberInfo attributes, Func<T, TContext, TEdited> getValue, Action<T, TContext, TEdited> setValue)
			{
				return null;
			}

			// Token: 0x0602C762 RID: 182114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C762")]
			public static tk<T, TContext>.PropertyEditor Create<TEdited>(fiGUIContent label, Func<T, TContext, TEdited> getValue)
			{
				return null;
			}

			// Token: 0x0602C763 RID: 182115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C763")]
			public static tk<T, TContext>.PropertyEditor Create<TEdited>(fiGUIContent label, Func<T, TContext, TEdited> getValue, Action<T, TContext, TEdited> setValue)
			{
				return null;
			}

			// Token: 0x0602C764 RID: 182116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C764")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C765 RID: 182117 RVA: 0x000E0340 File Offset: 0x000DE540
			[Token(Token = "0x602C765")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x040402F5 RID: 262901
			[Token(Token = "0x40402F5")]
			[FieldOffset(Offset = "0x0")]
			private MemberInfo _attributes;

			// Token: 0x040402F6 RID: 262902
			[Token(Token = "0x40402F6")]
			[FieldOffset(Offset = "0x0")]
			private Func<T, TContext, object> _getValue;

			// Token: 0x040402F7 RID: 262903
			[Token(Token = "0x40402F7")]
			[FieldOffset(Offset = "0x0")]
			private Action<T, TContext, object> _setValue;

			// Token: 0x040402F8 RID: 262904
			[Token(Token = "0x40402F8")]
			[FieldOffset(Offset = "0x0")]
			private tk<T, TContext>.Value<fiGUIContent> _label;

			// Token: 0x040402F9 RID: 262905
			[Token(Token = "0x40402F9")]
			[FieldOffset(Offset = "0x0")]
			private Type _fieldType;

			// Token: 0x040402FA RID: 262906
			[Token(Token = "0x40402FA")]
			[FieldOffset(Offset = "0x0")]
			private string _errorMessage;
		}

		// Token: 0x02007C3D RID: 31805
		[Token(Token = "0x2007C3D")]
		public class StyleProxy : tkControl<T, TContext>
		{
			// Token: 0x0602C775 RID: 182133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C775")]
			public StyleProxy()
			{
			}

			// Token: 0x0602C776 RID: 182134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C776")]
			public StyleProxy(tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C777 RID: 182135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C777")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C778 RID: 182136 RVA: 0x000E0358 File Offset: 0x000DE558
			[Token(Token = "0x602C778")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x04040304 RID: 262916
			[Token(Token = "0x4040304")]
			[FieldOffset(Offset = "0x0")]
			public tkControl<T, TContext> Control;
		}

		// Token: 0x02007C3E RID: 31806
		[Token(Token = "0x2007C3E")]
		public class ReadOnly : tk<T, TContext>.ReadOnlyIf
		{
			// Token: 0x0602C779 RID: 182137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C779")]
			public ReadOnly()
			{
			}
		}

		// Token: 0x02007C40 RID: 31808
		[Token(Token = "0x2007C40")]
		public class ReadOnlyIf : tk<T, TContext>.ConditionalStyle
		{
			// Token: 0x0602C77D RID: 182141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C77D")]
			public ReadOnlyIf(tk<T, TContext>.Value<bool> isReadOnly)
			{
			}

			// Token: 0x0602C77E RID: 182142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C77E")]
			public ReadOnlyIf(tk<T, TContext>.Value<bool>.Generator isReadOnly)
			{
			}

			// Token: 0x0602C77F RID: 182143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C77F")]
			public ReadOnlyIf(tk<T, TContext>.Value<bool>.GeneratorNoContext isReadOnly)
			{
			}
		}

		// Token: 0x02007C42 RID: 31810
		[Token(Token = "0x2007C42")]
		public class ShowIf : tkControl<T, TContext>
		{
			// Token: 0x0602C784 RID: 182148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C784")]
			public ShowIf(tk<T, TContext>.Value<bool> shouldDisplay, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C785 RID: 182149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C785")]
			public ShowIf(tk<T, TContext>.Value<bool>.Generator shouldDisplay, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C786 RID: 182150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C786")]
			public ShowIf(tk<T, TContext>.Value<bool>.GeneratorNoContext shouldDisplay, tkControl<T, TContext> control)
			{
			}

			// Token: 0x0602C787 RID: 182151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C787")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C788 RID: 182152 RVA: 0x000E0388 File Offset: 0x000DE588
			[Token(Token = "0x602C788")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x0602C789 RID: 182153 RVA: 0x000E03A0 File Offset: 0x000DE5A0
			[Token(Token = "0x602C789")]
			public override bool ShouldShow(T obj, TContext context, fiGraphMetadata metadata)
			{
				return default(bool);
			}

			// Token: 0x0404030A RID: 262922
			[Token(Token = "0x404030A")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<bool> _shouldDisplay;

			// Token: 0x0404030B RID: 262923
			[Token(Token = "0x404030B")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly tkControl<T, TContext> _control;
		}

		// Token: 0x02007C43 RID: 31811
		[Token(Token = "0x2007C43")]
		public class Slider : tkControl<T, TContext>
		{
			// Token: 0x0602C78A RID: 182154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C78A")]
			public Slider(tk<T, TContext>.Value<float> min, tk<T, TContext>.Value<float> max, Func<T, TContext, float> getValue, Action<T, TContext, float> setValue)
			{
			}

			// Token: 0x0602C78B RID: 182155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C78B")]
			public Slider(tk<T, TContext>.Value<fiGUIContent> label, tk<T, TContext>.Value<float> min, tk<T, TContext>.Value<float> max, Func<T, TContext, float> getValue, Action<T, TContext, float> setValue)
			{
			}

			// Token: 0x0602C78C RID: 182156 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C78C")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C78D RID: 182157 RVA: 0x000E03B8 File Offset: 0x000DE5B8
			[Token(Token = "0x602C78D")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x0404030C RID: 262924
			[Token(Token = "0x404030C")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<float> _min;

			// Token: 0x0404030D RID: 262925
			[Token(Token = "0x404030D")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<float> _max;

			// Token: 0x0404030E RID: 262926
			[Token(Token = "0x404030E")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<T, TContext, float> _getValue;

			// Token: 0x0404030F RID: 262927
			[Token(Token = "0x404030F")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<T, TContext, float> _setValue;

			// Token: 0x04040310 RID: 262928
			[Token(Token = "0x4040310")]
			[FieldOffset(Offset = "0x0")]
			private readonly tk<T, TContext>.Value<fiGUIContent> _label;
		}

		// Token: 0x02007C44 RID: 31812
		[Token(Token = "0x2007C44")]
		public class VerticalGroup : tkControl<T, TContext>, IEnumerable
		{
			// Token: 0x0602C78E RID: 182158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C78E")]
			public VerticalGroup()
			{
			}

			// Token: 0x0602C78F RID: 182159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C78F")]
			public VerticalGroup(float marginBetweenItems)
			{
			}

			// Token: 0x17006818 RID: 26648
			// (get) Token: 0x0602C790 RID: 182160 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17006818")]
			protected override IEnumerable<tkIControl> NonMemberChildControls
			{
				[Token(Token = "0x602C790")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602C791 RID: 182161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C791")]
			public void Add(tkControl<T, TContext> rule)
			{
			}

			// Token: 0x0602C792 RID: 182162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C792")]
			private void InternalAdd(tkControl<T, TContext> rule)
			{
			}

			// Token: 0x0602C793 RID: 182163 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C793")]
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
			{
				return null;
			}

			// Token: 0x0602C794 RID: 182164 RVA: 0x000E03D0 File Offset: 0x000DE5D0
			[Token(Token = "0x602C794")]
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata)
			{
				return 0f;
			}

			// Token: 0x0602C795 RID: 182165 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C795")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04040311 RID: 262929
			[Token(Token = "0x4040311")]
			[FieldOffset(Offset = "0x0")]
			[ShowInInspector]
			private readonly List<tk<T, TContext>.VerticalGroup.SectionItem> _items;

			// Token: 0x04040312 RID: 262930
			[Token(Token = "0x4040312")]
			[FieldOffset(Offset = "0x0")]
			private readonly float _marginBetweenItems;

			// Token: 0x02007C45 RID: 31813
			[Token(Token = "0x2007C45")]
			private struct SectionItem
			{
				// Token: 0x04040313 RID: 262931
				[Token(Token = "0x4040313")]
				[FieldOffset(Offset = "0x0")]
				public tkControl<T, TContext> Rule;
			}
		}

		// Token: 0x02007C47 RID: 31815
		[Token(Token = "0x2007C47")]
		public struct Value<TValue>
		{
			// Token: 0x0602C79F RID: 182175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C79F")]
			public Value(tk<T, TContext>.Value<TValue>.Generator generator)
			{
			}

			// Token: 0x0602C7A0 RID: 182176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C7A0")]
			public Value(tk<T, TContext>.Value<TValue>.GeneratorNoContext generator)
			{
			}

			// Token: 0x0602C7A1 RID: 182177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C7A1")]
			public TValue GetCurrentValue(T instance, TContext context)
			{
				return null;
			}

			// Token: 0x0602C7A2 RID: 182178 RVA: 0x000E0400 File Offset: 0x000DE600
			[Token(Token = "0x602C7A2")]
			public static implicit operator tk<T, TContext>.Value<TValue>(TValue direct)
			{
				return default(tk<T, TContext>.Value<TValue>);
			}

			// Token: 0x0602C7A3 RID: 182179 RVA: 0x000E0418 File Offset: 0x000DE618
			[Token(Token = "0x602C7A3")]
			public static implicit operator tk<T, TContext>.Value<TValue>(tk<T, TContext>.Value<TValue>.Generator generator)
			{
				return default(tk<T, TContext>.Value<TValue>);
			}

			// Token: 0x0602C7A4 RID: 182180 RVA: 0x000E0430 File Offset: 0x000DE630
			[Token(Token = "0x602C7A4")]
			public static implicit operator tk<T, TContext>.Value<TValue>(tk<T, TContext>.Value<TValue>.GeneratorNoContext generator)
			{
				return default(tk<T, TContext>.Value<TValue>);
			}

			// Token: 0x0602C7A5 RID: 182181 RVA: 0x000E0448 File Offset: 0x000DE648
			[Token(Token = "0x602C7A5")]
			public static implicit operator tk<T, TContext>.Value<TValue>(Func<T, int, TValue> generator)
			{
				return default(tk<T, TContext>.Value<TValue>);
			}

			// Token: 0x0602C7A6 RID: 182182 RVA: 0x000E0460 File Offset: 0x000DE660
			[Token(Token = "0x602C7A6")]
			public static implicit operator tk<T, TContext>.Value<TValue>(Func<T, TValue> generator)
			{
				return default(tk<T, TContext>.Value<TValue>);
			}

			// Token: 0x04040319 RID: 262937
			[Token(Token = "0x4040319")]
			[FieldOffset(Offset = "0x0")]
			private tk<T, TContext>.Value<TValue>.Generator _generator;

			// Token: 0x0404031A RID: 262938
			[Token(Token = "0x404031A")]
			[FieldOffset(Offset = "0x0")]
			private TValue _direct;

			// Token: 0x02007C48 RID: 31816
			// (Invoke) Token: 0x0602C7A8 RID: 182184
			[Token(Token = "0x2007C48")]
			public delegate TValue Generator(T input, TContext context);

			// Token: 0x02007C49 RID: 31817
			// (Invoke) Token: 0x0602C7AC RID: 182188
			[Token(Token = "0x2007C49")]
			public delegate TValue GeneratorNoContext(T input);
		}
	}
}
