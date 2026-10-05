using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class IMGUIContainer : VisualElement, IDisposable
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public Action onGUIHandler
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x5A36260", Offset = "0x5A34E60", VA = "0x185A36260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x5A36290", Offset = "0x5A34E90", VA = "0x185A36290")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000033")]
		internal ObjectGUIState guiState
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x5A36130", Offset = "0x5A34D30", VA = "0x185A36130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		internal Rect lastWorldClip
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x5A361F0", Offset = "0x5A34DF0", VA = "0x185A361F0")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x5A36280", Offset = "0x5A34E80", VA = "0x185A36280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x17000035")]
		public bool cullingEnabled
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x5A36110", Offset = "0x5A34D10", VA = "0x185A36110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000036")]
		private GUILayoutUtility.LayoutCache cache
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x5A36050", Offset = "0x5A34C50", VA = "0x185A36050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x17000037")]
		private float layoutMeasuredWidth
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x5A36230", Offset = "0x5A34E30", VA = "0x185A36230")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x17000038")]
		private float layoutMeasuredHeight
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x5A36200", Offset = "0x5A34E00", VA = "0x185A36200")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public ContextType contextType
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x3B3D7A0", Offset = "0x3B3C3A0", VA = "0x183B3D7A0")]
			[CompilerGenerated]
			get
			{
				return ContextType.Player;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x5A36270", Offset = "0x5A34E70", VA = "0x185A36270")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x1700003A")]
		internal bool focusOnlyIfHasFocusableControls
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x5A36120", Offset = "0x5A34D20", VA = "0x185A36120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x1700003B")]
		public override bool canGrabFocus
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x5A360E0", Offset = "0x5A34CE0", VA = "0x185A360E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x5A36040", Offset = "0x5A34C40", VA = "0x185A36040")]
		public IMGUIContainer()
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x5A35D60", Offset = "0x5A34960", VA = "0x185A35D60")]
		public IMGUIContainer(Action onGUIHandler)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x5A34D70", Offset = "0x5A33970", VA = "0x185A34D70")]
		private void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x5A35060", Offset = "0x5A33C60", VA = "0x185A35060")]
		private void SaveGlobals()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x5A34F10", Offset = "0x5A33B10", VA = "0x185A34F10")]
		private void RestoreGlobals()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x5A326E0", Offset = "0x5A312E0", VA = "0x185A326E0")]
		private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x5A34D50", Offset = "0x5A33950", VA = "0x185A34D50")]
		public void MarkDirtyLayout()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x5A33D30", Offset = "0x5A32930", VA = "0x185A33D30", Slot = "8")]
		public override void HandleEvent(EventBase evt)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x5A32050", Offset = "0x5A30C50", VA = "0x185A32050")]
		private void DoIMGUIRepaint()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x5A35260", Offset = "0x5A33E60", VA = "0x185A35260")]
		internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true)
		{
			return default(bool);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x5A35170", Offset = "0x5A33D70", VA = "0x185A35170")]
		private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds)
		{
			return default(bool);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x5A356B0", Offset = "0x5A342B0", VA = "0x185A356B0")]
		private bool VerifyBounds(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x5A346E0", Offset = "0x5A332E0", VA = "0x185A346E0")]
		private bool IsContainerCapturingTheMouse()
		{
			return default(bool);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x5A34B60", Offset = "0x5A33760", VA = "0x185A34B60")]
		private bool IsLocalEvent(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x5A34950", Offset = "0x5A33550", VA = "0x185A34950")]
		private bool IsEventInsideLocalWindow(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x5A347C0", Offset = "0x5A333C0", VA = "0x185A347C0")]
		private static bool IsDockAreaMouseUp(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x5A34080", Offset = "0x5A32C80", VA = "0x185A34080")]
		private bool HandleIMGUIEvent(Event e, bool canAffectFocus)
		{
			return default(bool);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x5A33DC0", Offset = "0x5A329C0", VA = "0x185A33DC0")]
		internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus)
		{
			return default(bool);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x5A34330", Offset = "0x5A32F30", VA = "0x185A34330")]
		private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus)
		{
			return default(bool);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x5A33680", Offset = "0x5A32280", VA = "0x185A33680", Slot = "12")]
		protected override void ExecuteDefaultAction(EventBase evt)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x5A35530", Offset = "0x5A34130", VA = "0x185A35530")]
		private void SetFoldoutDepthClass()
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x5A323C0", Offset = "0x5A30FC0", VA = "0x185A323C0", Slot = "95")]
		protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return default(Vector2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x5A33AA0", Offset = "0x5A326A0", VA = "0x185A33AA0")]
		private Rect GetCurrentClipRect()
		{
			return default(Rect);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x5A33B20", Offset = "0x5A32720", VA = "0x185A33B20")]
		private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x5A31FC0", Offset = "0x5A30BC0", VA = "0x185A31FC0", Slot = "97")]
		public void Dispose()
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x5A32030", Offset = "0x5A30C30", VA = "0x185A32030", Slot = "98")]
		protected virtual void Dispose(bool disposeManaged)
		{
		}

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x3B0")]
		private Action m_OnGUIHandler;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x3B8")]
		private ObjectGUIState m_ObjectGUIState;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x3C0")]
		internal bool useOwnerObjectGUIState;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x3D4")]
		private bool m_CullingEnabled;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x3D5")]
		private bool m_IsFocusDelegated;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x3D6")]
		private bool m_RefreshCachedLayout;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x3D8")]
		private GUILayoutUtility.LayoutCache m_Cache;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x3E0")]
		private Rect m_CachedClippingRect;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x3F0")]
		private Matrix4x4 m_CachedTransform;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x434")]
		private bool lostFocus;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x435")]
		private bool receivedFocus;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x438")]
		private FocusChangeDirection focusChangeDirection;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x440")]
		private bool hasFocusableControls;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x444")]
		private int newKeyboardFocusControlID;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly string ussFoldoutChildDepthClassName;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly List<string> ussFoldoutChildDepthClassNames;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x18")]
		internal static IMGUIContainer current;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x44C")]
		private IMGUIContainer.GUIGlobals m_GUIGlobals;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x20")]
		private static readonly ProfilerMarker k_OnGUIMarker;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x28")]
		private static readonly ProfilerMarker k_ImmediateCallbackMarker;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x30")]
		private static Event s_DefaultMeasureEvent;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x38")]
		private static Event s_MeasureEvent;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x40")]
		private static Event s_CurrentEvent;

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		public new class UxmlFactory : UxmlFactory<IMGUIContainer, IMGUIContainer.UxmlTraits>
		{
			// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x5A3BF20", Offset = "0x5A3AB20", VA = "0x185A3BF20")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x5A3C170", Offset = "0x5A3AD70", VA = "0x185A3C170")]
			public UxmlTraits()
			{
			}
		}

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x2000037")]
		private struct GUIGlobals
		{
			// Token: 0x040000AB RID: 171
			[Token(Token = "0x40000AB")]
			[FieldOffset(Offset = "0x0")]
			public Matrix4x4 matrix;

			// Token: 0x040000AC RID: 172
			[Token(Token = "0x40000AC")]
			[FieldOffset(Offset = "0x40")]
			public Color color;

			// Token: 0x040000AD RID: 173
			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x50")]
			public Color contentColor;

			// Token: 0x040000AE RID: 174
			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x60")]
			public Color backgroundColor;

			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0x70")]
			public bool enabled;

			// Token: 0x040000B0 RID: 176
			[Token(Token = "0x40000B0")]
			[FieldOffset(Offset = "0x71")]
			public bool changed;

			// Token: 0x040000B1 RID: 177
			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x74")]
			public int displayIndex;
		}
	}
}
