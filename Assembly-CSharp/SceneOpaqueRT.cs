using System;
using Il2CppDummyDll;
using Torappu.Rendering;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
[ExecuteInEditMode]
public class SceneOpaqueRT : BaseSceneEffect
{
	// Token: 0x060000AC RID: 172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x50E0D0", Offset = "0x50CCD0", VA = "0x18050E0D0", Slot = "6")]
	protected override void OnLateInit()
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x50DE10", Offset = "0x50CA10", VA = "0x18050DE10", Slot = "4")]
	public override void OnCameraChanged(Camera old, Camera current)
	{
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x50DB50", Offset = "0x50C750", VA = "0x18050DB50")]
	private void InitCamera(Camera camera)
	{
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x50DFE0", Offset = "0x50CBE0", VA = "0x18050DFE0", Slot = "7")]
	protected override void OnFinish()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x50E160", Offset = "0x50CD60", VA = "0x18050E160")]
	private void _ClearCurrentCamera()
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x50E210", Offset = "0x50CE10", VA = "0x18050E210")]
	public SceneOpaqueRT()
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x50E150", Offset = "0x50CD50", VA = "0x18050E150")]
	private void <>xLuaBaseProxy_OnLateInit()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x50E130", Offset = "0x50CD30", VA = "0x18050E130")]
	private void <>xLuaBaseProxy_OnCameraChanged(Camera P0, Camera P1)
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x50E140", Offset = "0x50CD40", VA = "0x18050E140")]
	private void <>xLuaBaseProxy_OnFinish()
	{
	}

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x20")]
	private CommandBuffer m_cmd;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x28")]
	private Camera m_camera;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x30")]
	private bool m_inited;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x38")]
	private Camera[] sceneCameras;

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x0")]
	private static DelegateBridge __Hotfix0_OnLateInit;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x8")]
	private static DelegateBridge __Hotfix0_OnCameraChanged;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x10")]
	private static DelegateBridge __Hotfix0_InitCamera;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x18")]
	private static DelegateBridge __Hotfix0_OnFinish;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x20")]
	private static DelegateBridge __Hotfix0__ClearCurrentCamera;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x28")]
	private static DelegateBridge _c__Hotfix0_ctor;
}
