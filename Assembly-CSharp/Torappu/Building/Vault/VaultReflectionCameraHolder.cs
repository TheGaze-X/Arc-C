using System;
using Il2CppDummyDll;
using Torappu.GraphicEffect.Reflection;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A42 RID: 6722
	[Token(Token = "0x2001A42")]
	public class VaultReflectionCameraHolder : ReflectCameraHolder, ILODListener, IHotfixable
	{
		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x0600A8A0 RID: 43168 RVA: 0x00041550 File Offset: 0x0003F750
		[Token(Token = "0x17001394")]
		public int priority
		{
			[Token(Token = "0x600A8A0")]
			[Address(RVA = "0x324F6F0", Offset = "0x324E2F0", VA = "0x18324F6F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x0600A8A1 RID: 43169 RVA: 0x00041568 File Offset: 0x0003F768
		[Token(Token = "0x17001395")]
		public override bool reflectEnable
		{
			[Token(Token = "0x600A8A1")]
			[Address(RVA = "0x324F790", Offset = "0x324E390", VA = "0x18324F790", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A8A2 RID: 43170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8A2")]
		[Address(RVA = "0x324F3F0", Offset = "0x324DFF0", VA = "0x18324F3F0", Slot = "5")]
		public void OnLODStateChanged(LODState state)
		{
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8A3")]
		[Address(RVA = "0x324F510", Offset = "0x324E110", VA = "0x18324F510")]
		public VaultReflectionCameraHolder(HGReflectionShaderProfile shaderProfile, VDIYRoom vRoom)
		{
		}

		// Token: 0x0600A8A4 RID: 43172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8A4")]
		[Address(RVA = "0x324F470", Offset = "0x324E070", VA = "0x18324F470")]
		private void _RefreshCameraByLOD()
		{
		}

		// Token: 0x0600A8A5 RID: 43173 RVA: 0x00041580 File Offset: 0x0003F780
		[Token(Token = "0x600A8A5")]
		[Address(RVA = "0x324F460", Offset = "0x324E060", VA = "0x18324F460")]
		private bool <>xLuaBaseProxy_get_reflectEnable()
		{
			return default(bool);
		}

		// Token: 0x0400A0CE RID: 41166
		[Token(Token = "0x400A0CE")]
		[FieldOffset(Offset = "0x48")]
		private LODState m_lodState;

		// Token: 0x0400A0CF RID: 41167
		[Token(Token = "0x400A0CF")]
		[FieldOffset(Offset = "0x50")]
		private bool m_enabledByLOD;

		// Token: 0x0400A0D0 RID: 41168
		[Token(Token = "0x400A0D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priority;

		// Token: 0x0400A0D1 RID: 41169
		[Token(Token = "0x400A0D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_reflectEnable;

		// Token: 0x0400A0D2 RID: 41170
		[Token(Token = "0x400A0D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLODStateChanged;

		// Token: 0x0400A0D3 RID: 41171
		[Token(Token = "0x400A0D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400A0D4 RID: 41172
		[Token(Token = "0x400A0D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshCameraByLOD;
	}
}
