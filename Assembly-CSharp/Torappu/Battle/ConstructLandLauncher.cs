using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021B1 RID: 8625
	[Token(Token = "0x20021B1")]
	public class ConstructLandLauncher : SingletonMonoBehaviour<ConstructLandLauncher>, ISingletonNotAutoCreate
	{
		// Token: 0x0600D75B RID: 55131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D75B")]
		[Address(RVA = "0x35CA620", Offset = "0x35C9220", VA = "0x1835CA620")]
		private LevelData _LoadLevelData(ConstructBattleSceneParam param)
		{
			return null;
		}

		// Token: 0x0600D75C RID: 55132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D75C")]
		[Address(RVA = "0x35CA0E0", Offset = "0x35C8CE0", VA = "0x1835CA0E0")]
		private void Start()
		{
		}

		// Token: 0x0600D75D RID: 55133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D75D")]
		[Address(RVA = "0x35CABF0", Offset = "0x35C97F0", VA = "0x1835CABF0")]
		public ConstructLandLauncher()
		{
		}

		// Token: 0x0400E7DB RID: 59355
		[Token(Token = "0x400E7DB")]
		private const int CONSTRUCT_COST = 999;

		// Token: 0x0400E7DC RID: 59356
		[Token(Token = "0x400E7DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadLevelData;

		// Token: 0x0400E7DD RID: 59357
		[Token(Token = "0x400E7DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400E7DE RID: 59358
		[Token(Token = "0x400E7DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
