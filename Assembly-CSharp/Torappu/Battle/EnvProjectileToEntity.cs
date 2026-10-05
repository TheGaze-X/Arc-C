using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002293 RID: 8851
	[Token(Token = "0x2002293")]
	public class EnvProjectileToEntity : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DEAF RID: 57007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEAF")]
		[Address(RVA = "0x3654020", Offset = "0x3652C20", VA = "0x183654020", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB0")]
		[Address(RVA = "0x3654190", Offset = "0x3652D90", VA = "0x183654190", Slot = "16")]
		public override void OnEnvChanged(string status, Entity target, [Optional] Entity sourceNullable)
		{
		}

		// Token: 0x0600DEB1 RID: 57009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB1")]
		[Address(RVA = "0x3654290", Offset = "0x3652E90", VA = "0x183654290")]
		private void _EmitProjectileToTarget(Entity target, [Optional] Entity source)
		{
		}

		// Token: 0x0600DEB2 RID: 57010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB2")]
		[Address(RVA = "0x3654510", Offset = "0x3653110", VA = "0x183654510")]
		public EnvProjectileToEntity()
		{
		}

		// Token: 0x0600DEB3 RID: 57011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB3")]
		[Address(RVA = "0x3633EF0", Offset = "0x3632AF0", VA = "0x183633EF0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DEB4 RID: 57012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB4")]
		[Address(RVA = "0x3634430", Offset = "0x3633030", VA = "0x183634430")]
		private void <>xLuaBaseProxy_OnEnvChanged(string P0, Entity P1, Entity P2)
		{
		}

		// Token: 0x0400F1AB RID: 61867
		[Token(Token = "0x400F1AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public List<string> _envStatus;

		// Token: 0x0400F1AC RID: 61868
		[Token(Token = "0x400F1AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x0400F1AD RID: 61869
		[Token(Token = "0x400F1AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Entity.MountPointType _targetMountPointType;

		// Token: 0x0400F1AE RID: 61870
		[Token(Token = "0x400F1AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Entity.MountPointType _sourceMountPointType;

		// Token: 0x0400F1AF RID: 61871
		[Token(Token = "0x400F1AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TargetOptions _options;

		// Token: 0x0400F1B0 RID: 61872
		[Token(Token = "0x400F1B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Ability m_ability;

		// Token: 0x0400F1B1 RID: 61873
		[Token(Token = "0x400F1B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F1B2 RID: 61874
		[Token(Token = "0x400F1B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F1B3 RID: 61875
		[Token(Token = "0x400F1B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EmitProjectileToTarget;

		// Token: 0x0400F1B4 RID: 61876
		[Token(Token = "0x400F1B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
