using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	internal static class UIElementsRuntimeUtility
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060004CB RID: 1227 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000A")]
		public static event Action<BaseRuntimePanel> onCreatePanel
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x5A96360", Offset = "0x5A94F60", VA = "0x185A96360")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x5A96640", Offset = "0x5A95240", VA = "0x185A96640")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x5A93DF0", Offset = "0x5A929F0", VA = "0x185A93DF0")]
		public static EventBase CreateEvent(Event systemEvent)
		{
			return null;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x5A93FF0", Offset = "0x5A92BF0", VA = "0x185A93FF0")]
		public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, UIElementsRuntimeUtility.CreateRuntimePanelDelegate createDelegate)
		{
			return null;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x5A93E60", Offset = "0x5A92A60", VA = "0x185A93E60")]
		public static void DisposeRuntimePanel(ScriptableObject ownerObject)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x5A947B0", Offset = "0x5A933B0", VA = "0x185A947B0")]
		private static void RegisterCachedPanelInternal(int instanceID, IPanel panel)
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x5A94CF0", Offset = "0x5A938F0", VA = "0x185A94CF0")]
		private static void RemoveCachedPanelInternal(int instanceID)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x5A952A0", Offset = "0x5A93EA0", VA = "0x185A952A0")]
		public static void RepaintOffscreenPanels()
		{
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x5A954C0", Offset = "0x5A940C0", VA = "0x185A954C0")]
		public static void RepaintOverlayPanel(BaseRuntimePanel panel)
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x5A93D90", Offset = "0x5A92990", VA = "0x185A93D90")]
		internal static void BeginRenderOverlays(int displayIndex)
		{
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x5A950B0", Offset = "0x5A93CB0", VA = "0x185A950B0")]
		internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority)
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x5A93F80", Offset = "0x5A92B80", VA = "0x185A93F80")]
		internal static void EndRenderOverlays(int displayIndex)
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012E")]
		internal static Object activeEventSystem
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x5A96470", Offset = "0x5A95070", VA = "0x185A96470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x5A96750", Offset = "0x5A95350", VA = "0x185A96750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x1700012F")]
		internal static bool useDefaultEventSystem
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x5A96590", Offset = "0x5A95190", VA = "0x185A96590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x5A949E0", Offset = "0x5A935E0", VA = "0x185A949E0")]
		public static void RegisterEventSystem(Object eventSystem)
		{
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x5A959A0", Offset = "0x5A945A0", VA = "0x185A959A0")]
		public static void UnregisterEventSystem(Object eventSystem)
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000130")]
		internal static DefaultEventSystem defaultEventSystem
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x5A964C0", Offset = "0x5A950C0", VA = "0x185A964C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x5A95B40", Offset = "0x5A94740", VA = "0x185A95B40")]
		public static void UpdateRuntimePanels()
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x5A942D0", Offset = "0x5A92ED0", VA = "0x185A942D0")]
		internal static void MarkPotentiallyEmpty(PanelSettings settings)
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x5A94EE0", Offset = "0x5A93AE0", VA = "0x185A94EE0")]
		internal static void RemoveUnusedPanels()
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x5A94C50", Offset = "0x5A93850", VA = "0x185A94C50")]
		public static void RegisterPlayerloopCallback()
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x5A95AE0", Offset = "0x5A946E0", VA = "0x185A95AE0")]
		public static void UnregisterPlayerloopCallback()
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x5A95740", Offset = "0x5A94340", VA = "0x185A95740")]
		internal static void SetPanelOrderingDirty()
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x5A94230", Offset = "0x5A92E30", VA = "0x185A94230")]
		internal static List<Panel> GetSortedPlayerPanels()
		{
			return null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x5A95790", Offset = "0x5A94390", VA = "0x185A95790")]
		private static void SortPanels()
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x5A943A0", Offset = "0x5A92FA0", VA = "0x185A943A0")]
		internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int? targetDisplay)
		{
			return default(Vector2);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x5A94620", Offset = "0x5A93220", VA = "0x185A94620")]
		internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out int? targetDisplay)
		{
			return default(Vector2);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x5A95660", Offset = "0x5A94260", VA = "0x185A95660")]
		internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay)
		{
			return default(Vector2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x5A95640", Offset = "0x5A94240", VA = "0x185A95640")]
		internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta)
		{
			return default(Vector2);
		}

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_RegisteredPlayerloopCallback;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x10")]
		private static List<Panel> s_SortedRuntimePanels;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x18")]
		private static bool s_PanelOrderingDirty;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly string s_RepaintProfilerMarkerName;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x28")]
		private static readonly ProfilerMarker s_RepaintProfilerMarker;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x30")]
		private static int currentOverlayIndex;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x40")]
		private static DefaultEventSystem s_DefaultEventSystem;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x48")]
		private static List<PanelSettings> s_PotentiallyEmptyPanelSettings;

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x060004EB RID: 1259
		[Token(Token = "0x20000A4")]
		public delegate BaseRuntimePanel CreateRuntimePanelDelegate(ScriptableObject ownerObject);
	}
}
