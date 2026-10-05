using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[RequireComponent(typeof(RectTransform))]
	[NativeClass("UI::Canvas")]
	[NativeHeader("Modules/UI/UIStructs.h")]
	[NativeHeader("Modules/UI/CanvasManager.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	public sealed class Canvas : Behaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public static event Canvas.WillRenderCanvases preWillRenderCanvases
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x5B524A0", Offset = "0x5B510A0", VA = "0x185B524A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x5B52BA0", Offset = "0x5B517A0", VA = "0x185B52BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		public static event Canvas.WillRenderCanvases willRenderCanvases
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x5B52560", Offset = "0x5B51160", VA = "0x185B52560")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x5B52C60", Offset = "0x5B51860", VA = "0x185B52C60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000044 RID: 68
		// (set) Token: 0x06000045 RID: 69
		[Token(Token = "0x1700000D")]
		public extern RenderMode renderMode { [Token(Token = "0x6000044")] [Address(RVA = "0x5B528C0", Offset = "0x5B514C0", VA = "0x185B528C0")] [MethodImpl(4096)] get; [Token(Token = "0x6000045")] [Address(RVA = "0x5B52F70", Offset = "0x5B51B70", VA = "0x185B52F70")] [MethodImpl(4096)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000046 RID: 70
		[Token(Token = "0x1700000E")]
		public extern bool isRootCanvas { [Token(Token = "0x6000046")] [Address(RVA = "0x5B52720", Offset = "0x5B51320", VA = "0x185B52720")] [MethodImpl(4096)] get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x1700000F")]
		public Rect pixelRect
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x5B52830", Offset = "0x5B51430", VA = "0x185B52830")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000048 RID: 72
		// (set) Token: 0x06000049 RID: 73
		[Token(Token = "0x17000010")]
		public extern float scaleFactor { [Token(Token = "0x6000048")] [Address(RVA = "0x5B52A20", Offset = "0x5B51620", VA = "0x185B52A20")] [MethodImpl(4096)] get; [Token(Token = "0x6000049")] [Address(RVA = "0x5B52FB0", Offset = "0x5B51BB0", VA = "0x185B52FB0")] [MethodImpl(4096)] set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004A RID: 74
		// (set) Token: 0x0600004B RID: 75
		[Token(Token = "0x17000011")]
		public extern float referencePixelsPerUnit { [Token(Token = "0x600004A")] [Address(RVA = "0x5B52880", Offset = "0x5B51480", VA = "0x185B52880")] [MethodImpl(4096)] get; [Token(Token = "0x600004B")] [Address(RVA = "0x5B52F20", Offset = "0x5B51B20", VA = "0x185B52F20")] [MethodImpl(4096)] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004C RID: 76
		[Token(Token = "0x17000012")]
		public extern bool pixelPerfect { [Token(Token = "0x600004C")] [Address(RVA = "0x5B527A0", Offset = "0x5B513A0", VA = "0x185B527A0")] [MethodImpl(4096)] get; }

		// Token: 0x17000013 RID: 19
		// (set) Token: 0x0600004D RID: 77
		[Token(Token = "0x17000013")]
		public extern float planeDistance { [Token(Token = "0x600004D")] [Address(RVA = "0x5B52ED0", Offset = "0x5B51AD0", VA = "0x185B52ED0")] [MethodImpl(4096)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004E RID: 78
		[Token(Token = "0x17000014")]
		public extern int renderOrder { [Token(Token = "0x600004E")] [Address(RVA = "0x5B52900", Offset = "0x5B51500", VA = "0x185B52900")] [MethodImpl(4096)] get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004F RID: 79
		// (set) Token: 0x06000050 RID: 80
		[Token(Token = "0x17000015")]
		public extern bool overrideSorting { [Token(Token = "0x600004F")] [Address(RVA = "0x5B52760", Offset = "0x5B51360", VA = "0x185B52760")] [MethodImpl(4096)] get; [Token(Token = "0x6000050")] [Address(RVA = "0x5B52E80", Offset = "0x5B51A80", VA = "0x185B52E80")] [MethodImpl(4096)] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000051 RID: 81
		// (set) Token: 0x06000052 RID: 82
		[Token(Token = "0x17000016")]
		public extern int sortingOrder { [Token(Token = "0x6000051")] [Address(RVA = "0x5B52AE0", Offset = "0x5B516E0", VA = "0x185B52AE0")] [MethodImpl(4096)] get; [Token(Token = "0x6000052")] [Address(RVA = "0x5B53090", Offset = "0x5B51C90", VA = "0x185B53090")] [MethodImpl(4096)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000053 RID: 83
		[Token(Token = "0x17000017")]
		public extern int targetDisplay { [Token(Token = "0x6000053")] [Address(RVA = "0x5B52B20", Offset = "0x5B51720", VA = "0x185B52B20")] [MethodImpl(4096)] get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000054 RID: 84
		// (set) Token: 0x06000055 RID: 85
		[Token(Token = "0x17000018")]
		public extern int sortingLayerID { [Token(Token = "0x6000054")] [Address(RVA = "0x5B52A60", Offset = "0x5B51660", VA = "0x185B52A60")] [MethodImpl(4096)] get; [Token(Token = "0x6000055")] [Address(RVA = "0x5B53000", Offset = "0x5B51C00", VA = "0x185B53000")] [MethodImpl(4096)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000056 RID: 86
		// (set) Token: 0x06000057 RID: 87
		[Token(Token = "0x17000019")]
		public extern AdditionalCanvasShaderChannels additionalShaderChannels { [Token(Token = "0x6000056")] [Address(RVA = "0x5B52620", Offset = "0x5B51220", VA = "0x185B52620")] [MethodImpl(4096)] get; [Token(Token = "0x6000057")] [Address(RVA = "0x5B52D20", Offset = "0x5B51920", VA = "0x185B52D20")] [MethodImpl(4096)] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000058 RID: 88
		// (set) Token: 0x06000059 RID: 89
		[Token(Token = "0x1700001A")]
		public extern string sortingLayerName { [Token(Token = "0x6000058")] [Address(RVA = "0x5B52AA0", Offset = "0x5B516A0", VA = "0x185B52AA0")] [MethodImpl(4096)] get; [Token(Token = "0x6000059")] [Address(RVA = "0x5B53040", Offset = "0x5B51C40", VA = "0x185B53040")] [MethodImpl(4096)] set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005A RID: 90
		[Token(Token = "0x1700001B")]
		public extern Canvas rootCanvas { [Token(Token = "0x600005A")] [Address(RVA = "0x5B529E0", Offset = "0x5B515E0", VA = "0x185B529E0")] [MethodImpl(4096)] get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x1700001C")]
		public Vector2 renderingDisplaySize
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x5B52990", Offset = "0x5B51590", VA = "0x185B52990")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001D")]
		internal static Action<int> externBeginRenderOverlays
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x5B52660", Offset = "0x5B51260", VA = "0x185B52660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x5B52D60", Offset = "0x5B51960", VA = "0x185B52D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001E")]
		internal static Action<int, int> externRenderOverlaysBefore
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x5B526E0", Offset = "0x5B512E0", VA = "0x185B526E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x5B52E20", Offset = "0x5B51A20", VA = "0x185B52E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001F")]
		internal static Action<int> externEndRenderOverlays
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x5B526A0", Offset = "0x5B512A0", VA = "0x185B526A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x5B52DC0", Offset = "0x5B519C0", VA = "0x185B52DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000062 RID: 98
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x5B52460", Offset = "0x5B51060", VA = "0x185B52460")]
		[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
		[MethodImpl(4096)]
		internal static extern void SetExternalCanvasEnabled(bool enabled);

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000063 RID: 99
		// (set) Token: 0x06000064 RID: 100
		[Token(Token = "0x17000020")]
		[NativeProperty("Camera", false, TargetType.Function)]
		public extern Camera worldCamera { [Token(Token = "0x6000063")] [Address(RVA = "0x5B52B60", Offset = "0x5B51760", VA = "0x185B52B60")] [MethodImpl(4096)] get; [Token(Token = "0x6000064")] [Address(RVA = "0x5B530D0", Offset = "0x5B51CD0", VA = "0x185B530D0")] [MethodImpl(4096)] set; }

		// Token: 0x06000065 RID: 101
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5B52300", Offset = "0x5B50F00", VA = "0x185B52300")]
		[FreeFunction("UI::GetDefaultUIMaterial")]
		[MethodImpl(4096)]
		public static extern Material GetDefaultCanvasMaterial();

		// Token: 0x06000066 RID: 102
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5B52330", Offset = "0x5B50F30", VA = "0x185B52330")]
		[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
		[MethodImpl(4096)]
		public static extern Material GetETC1SupportedCanvasMaterial();

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5B52270", Offset = "0x5B50E70", VA = "0x185B52270")]
		public static void ForceUpdateCanvases()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x5B523C0", Offset = "0x5B50FC0", VA = "0x185B523C0")]
		[RequiredByNativeCode]
		private static void SendPreWillRenderCanvases()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x5B52410", Offset = "0x5B51010", VA = "0x185B52410")]
		[RequiredByNativeCode]
		private static void SendWillRenderCanvases()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x5B521B0", Offset = "0x5B50DB0", VA = "0x185B521B0")]
		[RequiredByNativeCode]
		private static void BeginRenderExtraOverlays(int displayIndex)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x5B52360", Offset = "0x5B50F60", VA = "0x185B52360")]
		[RequiredByNativeCode]
		private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x5B52210", Offset = "0x5B50E10", VA = "0x185B52210")]
		[RequiredByNativeCode]
		private static void EndRenderExtraOverlays(int displayIndex)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Canvas()
		{
		}

		// Token: 0x0600006E RID: 110
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x5B527E0", Offset = "0x5B513E0", VA = "0x185B527E0")]
		[MethodImpl(4096)]
		private extern void get_pixelRect_Injected(out Rect ret);

		// Token: 0x0600006F RID: 111
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x5B52940", Offset = "0x5B51540", VA = "0x185B52940")]
		[MethodImpl(4096)]
		private extern void get_renderingDisplaySize_Injected(out Vector2 ret);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000071 RID: 113
		[Token(Token = "0x2000009")]
		public delegate void WillRenderCanvases();
	}
}
