using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Opera;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002634 RID: 9780
	[Token(Token = "0x2002634")]
	public class OperaController : IHotfixable
	{
		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x0601000C RID: 65548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022F5")]
		public object param
		{
			[Token(Token = "0x601000C")]
			[Address(RVA = "0x7829E0", Offset = "0x7815E0", VA = "0x1807829E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601000D RID: 65549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601000D")]
		[Address(RVA = "0x782480", Offset = "0x781080", VA = "0x180782480")]
		public void PlayOpera(string key, object param)
		{
		}

		// Token: 0x0601000E RID: 65550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601000E")]
		[Address(RVA = "0x7820D0", Offset = "0x780CD0", VA = "0x1807820D0")]
		public void Init(string config, out CameraController.PostprocessMask mask)
		{
		}

		// Token: 0x0601000F RID: 65551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601000F")]
		[Address(RVA = "0x7828A0", Offset = "0x7814A0", VA = "0x1807828A0")]
		private void _LoadConfigIfNot(string configPath)
		{
		}

		// Token: 0x06010010 RID: 65552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010010")]
		[Address(RVA = "0x7822F0", Offset = "0x780EF0", VA = "0x1807822F0")]
		public static List<OperaCommand> LoadOperaCommands(string configPath)
		{
			return null;
		}

		// Token: 0x06010011 RID: 65553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010011")]
		[Address(RVA = "0x781FB0", Offset = "0x780BB0", VA = "0x180781FB0")]
		public void Clear()
		{
		}

		// Token: 0x06010012 RID: 65554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010012")]
		[Address(RVA = "0x782790", Offset = "0x781390", VA = "0x180782790")]
		private void _Complete()
		{
		}

		// Token: 0x06010013 RID: 65555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010013")]
		[Address(RVA = "0x782930", Offset = "0x781530", VA = "0x180782930")]
		public OperaController()
		{
		}

		// Token: 0x04011C68 RID: 72808
		[Token(Token = "0x4011C68")]
		[FieldOffset(Offset = "0x10")]
		private List<OperaCommand> m_commands;

		// Token: 0x04011C69 RID: 72809
		[Token(Token = "0x4011C69")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isLocked;

		// Token: 0x04011C6A RID: 72810
		[Token(Token = "0x4011C6A")]
		[FieldOffset(Offset = "0x20")]
		private CoroutineId m_coroutine;

		// Token: 0x04011C6B RID: 72811
		[Token(Token = "0x4011C6B")]
		[FieldOffset(Offset = "0x30")]
		private List<Action> m_nodesOnCompletedCallback;

		// Token: 0x04011C6C RID: 72812
		[Token(Token = "0x4011C6C")]
		[FieldOffset(Offset = "0x38")]
		private object m_param;

		// Token: 0x04011C6D RID: 72813
		[Token(Token = "0x4011C6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x04011C6E RID: 72814
		[Token(Token = "0x4011C6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayOpera;

		// Token: 0x04011C6F RID: 72815
		[Token(Token = "0x4011C6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04011C70 RID: 72816
		[Token(Token = "0x4011C70")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadConfigIfNot;

		// Token: 0x04011C71 RID: 72817
		[Token(Token = "0x4011C71")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadOperaCommands;

		// Token: 0x04011C72 RID: 72818
		[Token(Token = "0x4011C72")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04011C73 RID: 72819
		[Token(Token = "0x4011C73")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Complete;

		// Token: 0x04011C74 RID: 72820
		[Token(Token = "0x4011C74")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
