using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	internal class UIElementsUtility : IUIElementsUtility
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x5A98470", Offset = "0x5A97070", VA = "0x185A98470")]
		private UIElementsUtility()
		{
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x5A97C70", Offset = "0x5A96870", VA = "0x185A97C70", Slot = "9")]
		private bool MakeCurrentIMGUIContainerDirty()
		{
			return default(bool);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x5A97EB0", Offset = "0x5A96AB0", VA = "0x185A97EB0", Slot = "4")]
		private bool TakeCapture()
		{
			return default(bool);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x591F3A0", Offset = "0x591DFA0", VA = "0x18591F3A0", Slot = "5")]
		private bool ReleaseCapture()
		{
			return default(bool);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x5A97D30", Offset = "0x5A96930", VA = "0x185A97D30", Slot = "6")]
		private bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled)
		{
			return default(bool);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x5A97AE0", Offset = "0x5A966E0", VA = "0x185A97AE0", Slot = "7")]
		private bool CleanupRoots()
		{
			return default(bool);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x5A97BB0", Offset = "0x5A967B0", VA = "0x185A97BB0", Slot = "8")]
		private bool EndContainerGUIFromException(Exception exception)
		{
			return default(bool);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x5A97940", Offset = "0x5A96540", VA = "0x185A97940")]
		public static void RegisterCachedPanel(int instanceID, Panel panel)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x5A979D0", Offset = "0x5A965D0", VA = "0x185A979D0")]
		public static void RemoveCachedPanel(int instanceID)
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x5A97A50", Offset = "0x5A96650", VA = "0x185A97A50")]
		public static bool TryGetPanel(int instanceID, out Panel panel)
		{
			return default(bool);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x5A967C0", Offset = "0x5A953C0", VA = "0x185A967C0")]
		internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x5A97400", Offset = "0x5A96000", VA = "0x185A97400")]
		internal static void EndContainerGUI(Event evt, Rect layoutSize)
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x5A969F0", Offset = "0x5A955F0", VA = "0x185A969F0")]
		internal static EventBase CreateEvent(Event systemEvent)
		{
			return null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x5A96A60", Offset = "0x5A95660", VA = "0x185A96A60")]
		internal static EventBase CreateEvent(Event systemEvent, EventType eventType)
		{
			return null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x5A96DD0", Offset = "0x5A959D0", VA = "0x185A96DD0")]
		private static bool DoDispatch(BaseVisualElementPanel panel)
		{
			return default(bool);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x5A97640", Offset = "0x5A96240", VA = "0x185A97640")]
		internal static void GetAllPanels(List<Panel> panels, ContextType contextType)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x5A977E0", Offset = "0x5A963E0", VA = "0x185A977E0")]
		internal static Dictionary<int, Panel>.Enumerator GetPanelsIterator()
		{
			return default(Dictionary<int, Panel>.Enumerator);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x5A97890", Offset = "0x5A96490", VA = "0x185A97890")]
		internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite)
		{
			return 0f;
		}

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x0")]
		private static Stack<IMGUIContainer> s_ContainerStack;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, Panel> s_UIElementsCache;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x10")]
		private static Event s_EventInstance;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x18")]
		internal static Color editorPlayModeTintColor;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x28")]
		internal static float singleLineHeight;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x30")]
		private static UIElementsUtility s_Instance;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x38")]
		internal static List<Panel> s_PanelsIterationList;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x40")]
		internal static readonly string s_RepaintProfilerMarkerName;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x48")]
		internal static readonly string s_EventProfilerMarkerName;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x50")]
		private static readonly ProfilerMarker s_RepaintProfilerMarker;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x58")]
		private static readonly ProfilerMarker s_EventProfilerMarker;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x60")]
		internal static char[] s_Modifiers;
	}
}
