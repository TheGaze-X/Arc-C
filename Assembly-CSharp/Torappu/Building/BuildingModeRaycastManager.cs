using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x0200180C RID: 6156
	[Token(Token = "0x200180C")]
	public class BuildingModeRaycastManager
	{
		// Token: 0x06009BD8 RID: 39896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD8")]
		[Address(RVA = "0x3154EE0", Offset = "0x3153AE0", VA = "0x183154EE0")]
		public void Block(RaycastBlockKey key)
		{
		}

		// Token: 0x06009BD9 RID: 39897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD9")]
		[Address(RVA = "0x3154CD0", Offset = "0x31538D0", VA = "0x183154CD0")]
		public void BlockAll(RaycastBlockKey key)
		{
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BDA")]
		[Address(RVA = "0x3155150", Offset = "0x3153D50", VA = "0x183155150")]
		public void Unblock(RaycastBlockKey key)
		{
		}

		// Token: 0x06009BDB RID: 39899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BDB")]
		[Address(RVA = "0x3154D20", Offset = "0x3153920", VA = "0x183154D20")]
		public void BlockRaycast(IBuildingMode buildingMode, bool isBlock)
		{
		}

		// Token: 0x06009BDC RID: 39900 RVA: 0x0003CB70 File Offset: 0x0003AD70
		[Token(Token = "0x6009BDC")]
		[Address(RVA = "0x3154FF0", Offset = "0x3153BF0", VA = "0x183154FF0")]
		public bool IsBlockRayCast(IBuildingMode mode)
		{
			return default(bool);
		}

		// Token: 0x06009BDD RID: 39901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BDD")]
		[Address(RVA = "0x3155220", Offset = "0x3153E20", VA = "0x183155220")]
		private BuildingModeRaycastManager.BlockContext _SecureContext(RaycastBlockKey key)
		{
			return null;
		}

		// Token: 0x06009BDE RID: 39902 RVA: 0x0003CB88 File Offset: 0x0003AD88
		[Token(Token = "0x6009BDE")]
		[Address(RVA = "0x3155190", Offset = "0x3153D90", VA = "0x183155190")]
		private BuildingModeRaycastManager.Mode _GetMode(IBuildingMode buildingMode)
		{
			return BuildingModeRaycastManager.Mode.NONE;
		}

		// Token: 0x06009BDF RID: 39903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BDF")]
		[Address(RVA = "0x31552F0", Offset = "0x3153EF0", VA = "0x1831552F0")]
		private void _UpdateBlockStatus()
		{
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BE0")]
		[Address(RVA = "0x3155410", Offset = "0x3154010", VA = "0x183155410")]
		public BuildingModeRaycastManager()
		{
		}

		// Token: 0x0400928B RID: 37515
		[Token(Token = "0x400928B")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<RaycastBlockKey, BuildingModeRaycastManager.BlockContext> m_blockInfos;

		// Token: 0x0200180D RID: 6157
		[Token(Token = "0x200180D")]
		private enum Mode
		{
			// Token: 0x0400928D RID: 37517
			[Token(Token = "0x400928D")]
			NONE,
			// Token: 0x0400928E RID: 37518
			[Token(Token = "0x400928E")]
			VAULT,
			// Token: 0x0400928F RID: 37519
			[Token(Token = "0x400928F")]
			BLUEPRINT,
			// Token: 0x04009290 RID: 37520
			[Token(Token = "0x4009290")]
			ALL
		}

		// Token: 0x0200180E RID: 6158
		[Token(Token = "0x200180E")]
		private class BlockContext
		{
			// Token: 0x06009BE1 RID: 39905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009BE1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BlockContext()
			{
			}

			// Token: 0x04009291 RID: 37521
			[Token(Token = "0x4009291")]
			[FieldOffset(Offset = "0x10")]
			public BuildingModeRaycastManager.Mode modeType;

			// Token: 0x04009292 RID: 37522
			[Token(Token = "0x4009292")]
			[FieldOffset(Offset = "0x14")]
			public bool isBlocked;
		}
	}
}
