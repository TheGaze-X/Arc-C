using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Yoga
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[NativeHeader("Modules/UIElementsNative/YogaNative.bindings.h")]
	internal static class Native
	{
		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x5B4BEF0", Offset = "0x5B4AAF0", VA = "0x185B4BEF0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern IntPtr YGNodeNewWithConfig(IntPtr config);

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5B4BA10", Offset = "0x5B4A610", VA = "0x185B4BA10")]
		public static void YGNodeFree(IntPtr ygNode)
		{
		}

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5B4B9D0", Offset = "0x5B4A5D0", VA = "0x185B4B9D0")]
		[FreeFunction(Name = "YGNodeFree", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void YGNodeFreeInternal(IntPtr ygNode);

		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5B4CBA0", Offset = "0x5B4B7A0", VA = "0x185B4CBA0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGSetManagedObject(IntPtr ygNode, YogaNode node);

		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5B4BFC0", Offset = "0x5B4ABC0", VA = "0x185B4BFC0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeSetConfig(IntPtr ygNode, IntPtr config);

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5B4B710", Offset = "0x5B4A310", VA = "0x185B4B710")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern IntPtr YGConfigGetDefault();

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5B4B780", Offset = "0x5B4A380", VA = "0x185B4B780")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern IntPtr YGConfigNew();

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5B4B690", Offset = "0x5B4A290", VA = "0x185B4B690")]
		public static void YGConfigFree(IntPtr config)
		{
		}

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5B4B650", Offset = "0x5B4A250", VA = "0x185B4B650")]
		[FreeFunction(Name = "YGConfigFree", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void YGConfigFreeInternal(IntPtr config);

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5B4B800", Offset = "0x5B4A400", VA = "0x185B4B800")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults);

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5B4B740", Offset = "0x5B4A340", VA = "0x185B4B740")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern bool YGConfigGetUseWebDefaults(IntPtr config);

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5B4B7B0", Offset = "0x5B4A3B0", VA = "0x185B4B7B0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint);

		// Token: 0x0600001D RID: 29
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5B4BAD0", Offset = "0x5B4A6D0", VA = "0x185B4BAD0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeInsertChild(IntPtr node, IntPtr child, uint index);

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5B4BF30", Offset = "0x5B4AB30", VA = "0x185B4BF30")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeRemoveChild(IntPtr node, IntPtr child);

		// Token: 0x0600001F RID: 31
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5B4B910", Offset = "0x5B4A510", VA = "0x185B4B910")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection);

		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5B4BDB0", Offset = "0x5B4A9B0", VA = "0x185B4BDB0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeMarkDirty(IntPtr node);

		// Token: 0x06000021 RID: 33
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5B4BB30", Offset = "0x5B4A730", VA = "0x185B4BB30")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern bool YGNodeIsDirty(IntPtr node);

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5B4B980", Offset = "0x5B4A580", VA = "0x185B4B980")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode);

		// Token: 0x06000023 RID: 35
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x5B4C060", Offset = "0x5B4AC60", VA = "0x185B4C060")]
		[FreeFunction(Name = "YogaCallback::SetMeasureFunc")]
		[MethodImpl(4096)]
		public static extern void YGNodeSetMeasureFunc(IntPtr node);

		// Token: 0x06000024 RID: 36
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x5B4BF80", Offset = "0x5B4AB80", VA = "0x185B4BF80")]
		[FreeFunction(Name = "YogaCallback::RemoveMeasureFunc")]
		[MethodImpl(4096)]
		public static extern void YGNodeRemoveMeasureFunc(IntPtr node);

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x5B4BDF0", Offset = "0x5B4A9F0", VA = "0x185B4BDF0")]
		[RequiredByNativeCode]
		public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x5B4B850", Offset = "0x5B4A450", VA = "0x185B4B850")]
		[RequiredByNativeCode]
		public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress)
		{
		}

		// Token: 0x06000027 RID: 39
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x5B4C010", Offset = "0x5B4AC10", VA = "0x185B4C010")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout);

		// Token: 0x06000028 RID: 40
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x5B4BA90", Offset = "0x5B4A690", VA = "0x185B4BA90")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern bool YGNodeGetHasNewLayout(IntPtr node);

		// Token: 0x06000029 RID: 41
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5B4C0A0", Offset = "0x5B4ACA0", VA = "0x185B4C0A0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern YogaDirection YGNodeStyleGetDirection(IntPtr node);

		// Token: 0x0600002A RID: 42
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x5B4C310", Offset = "0x5B4AF10", VA = "0x185B4C310")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection);

		// Token: 0x0600002B RID: 43
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x5B4C560", Offset = "0x5B4B160", VA = "0x185B4C560")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent);

		// Token: 0x0600002C RID: 44
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5B4C0E0", Offset = "0x5B4ACE0", VA = "0x185B4C0E0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent);

		// Token: 0x0600002D RID: 45
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x5B4C120", Offset = "0x5B4AD20", VA = "0x185B4C120")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems);

		// Token: 0x0600002E RID: 46
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x5B4C160", Offset = "0x5B4AD60", VA = "0x185B4C160")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf);

		// Token: 0x0600002F RID: 47
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5B4CA30", Offset = "0x5B4B630", VA = "0x185B4CA30")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType);

		// Token: 0x06000030 RID: 48
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x5B4C3F0", Offset = "0x5B4AFF0", VA = "0x185B4C3F0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap);

		// Token: 0x06000031 RID: 49
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x5B4C900", Offset = "0x5B4B500", VA = "0x185B4C900")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap);

		// Token: 0x06000032 RID: 50
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x5B4C1F0", Offset = "0x5B4ADF0", VA = "0x185B4C1F0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display);

		// Token: 0x06000033 RID: 51
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x5B4C430", Offset = "0x5B4B030", VA = "0x185B4C430")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetFlex(IntPtr node, float flex);

		// Token: 0x06000034 RID: 52
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x5B4C350", Offset = "0x5B4AF50", VA = "0x185B4C350")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow);

		// Token: 0x06000035 RID: 53
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x5B4C3A0", Offset = "0x5B4AFA0", VA = "0x185B4C3A0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink);

		// Token: 0x06000036 RID: 54
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x5B4C2C0", Offset = "0x5B4AEC0", VA = "0x185B4C2C0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis);

		// Token: 0x06000037 RID: 55
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x5B4C270", Offset = "0x5B4AE70", VA = "0x185B4C270")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis);

		// Token: 0x06000038 RID: 56
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x5B4C230", Offset = "0x5B4AE30", VA = "0x185B4C230")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetFlexBasisAuto(IntPtr node);

		// Token: 0x06000039 RID: 57
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x5B4CB50", Offset = "0x5B4B750", VA = "0x185B4CB50")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetWidth(IntPtr node, float width);

		// Token: 0x0600003A RID: 58
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x5B4CB00", Offset = "0x5B4B700", VA = "0x185B4CB00")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetWidthPercent(IntPtr node, float width);

		// Token: 0x0600003B RID: 59
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x5B4CAC0", Offset = "0x5B4B6C0", VA = "0x185B4CAC0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetWidthAuto(IntPtr node);

		// Token: 0x0600003C RID: 60
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5B4C510", Offset = "0x5B4B110", VA = "0x185B4C510")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetHeight(IntPtr node, float height);

		// Token: 0x0600003D RID: 61
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x5B4C4C0", Offset = "0x5B4B0C0", VA = "0x185B4C4C0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetHeightPercent(IntPtr node, float height);

		// Token: 0x0600003E RID: 62
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x5B4C480", Offset = "0x5B4B080", VA = "0x185B4C480")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetHeightAuto(IntPtr node);

		// Token: 0x0600003F RID: 63
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x5B4C8B0", Offset = "0x5B4B4B0", VA = "0x185B4C8B0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMinWidth(IntPtr node, float minWidth);

		// Token: 0x06000040 RID: 64
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x5B4C860", Offset = "0x5B4B460", VA = "0x185B4C860")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth);

		// Token: 0x06000041 RID: 65
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x5B4C810", Offset = "0x5B4B410", VA = "0x185B4C810")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMinHeight(IntPtr node, float minHeight);

		// Token: 0x06000042 RID: 66
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x5B4C7C0", Offset = "0x5B4B3C0", VA = "0x185B4C7C0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight);

		// Token: 0x06000043 RID: 67
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x5B4C770", Offset = "0x5B4B370", VA = "0x185B4C770")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth);

		// Token: 0x06000044 RID: 68
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x5B4C720", Offset = "0x5B4B320", VA = "0x185B4C720")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth);

		// Token: 0x06000045 RID: 69
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x5B4C6D0", Offset = "0x5B4B2D0", VA = "0x185B4C6D0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight);

		// Token: 0x06000046 RID: 70
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x5B4C680", Offset = "0x5B4B280", VA = "0x185B4C680")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight);

		// Token: 0x06000047 RID: 71
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5B4CA70", Offset = "0x5B4B670", VA = "0x185B4CA70")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position);

		// Token: 0x06000048 RID: 72
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5B4C9E0", Offset = "0x5B4B5E0", VA = "0x185B4C9E0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position);

		// Token: 0x06000049 RID: 73
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x5B4C630", Offset = "0x5B4B230", VA = "0x185B4C630")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin);

		// Token: 0x0600004A RID: 74
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x5B4C5E0", Offset = "0x5B4B1E0", VA = "0x185B4C5E0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin);

		// Token: 0x0600004B RID: 75
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5B4C5A0", Offset = "0x5B4B1A0", VA = "0x185B4C5A0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge);

		// Token: 0x0600004C RID: 76
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x5B4C990", Offset = "0x5B4B590", VA = "0x185B4C990")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding);

		// Token: 0x0600004D RID: 77
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x5B4C940", Offset = "0x5B4B540", VA = "0x185B4C940")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding);

		// Token: 0x0600004E RID: 78
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x5B4C1A0", Offset = "0x5B4ADA0", VA = "0x185B4C1A0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border);

		// Token: 0x0600004F RID: 79
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x5B4BC30", Offset = "0x5B4A830", VA = "0x185B4BC30")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float YGNodeLayoutGetLeft(IntPtr node);

		// Token: 0x06000050 RID: 80
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x5B4BD30", Offset = "0x5B4A930", VA = "0x185B4BD30")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float YGNodeLayoutGetTop(IntPtr node);

		// Token: 0x06000051 RID: 81
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x5B4BCF0", Offset = "0x5B4A8F0", VA = "0x185B4BCF0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float YGNodeLayoutGetRight(IntPtr node);

		// Token: 0x06000052 RID: 82
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x5B4BBB0", Offset = "0x5B4A7B0", VA = "0x185B4BBB0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float YGNodeLayoutGetBottom(IntPtr node);

		// Token: 0x06000053 RID: 83
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5B4BD70", Offset = "0x5B4A970", VA = "0x185B4BD70")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float YGNodeLayoutGetWidth(IntPtr node);

		// Token: 0x06000054 RID: 84
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x5B4BBF0", Offset = "0x5B4A7F0", VA = "0x185B4BBF0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float YGNodeLayoutGetHeight(IntPtr node);

		// Token: 0x06000055 RID: 85
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x5B4BC70", Offset = "0x5B4A870", VA = "0x185B4BC70")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge);

		// Token: 0x06000056 RID: 86
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x5B4BCB0", Offset = "0x5B4A8B0", VA = "0x185B4BCB0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge);

		// Token: 0x06000057 RID: 87
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x5B4BB70", Offset = "0x5B4A770", VA = "0x185B4BB70")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float YGNodeLayoutGetBorder(IntPtr node, YogaEdge edge);
	}
}
