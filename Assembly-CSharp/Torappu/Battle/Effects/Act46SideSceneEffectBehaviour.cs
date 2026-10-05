using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003255 RID: 12885
	[Token(Token = "0x2003255")]
	public class Act46SideSceneEffectBehaviour : Effect.Behaviour
	{
		// Token: 0x060146F5 RID: 83701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F5")]
		[Address(RVA = "0xC996F0", Offset = "0xC982F0", VA = "0x180C996F0")]
		protected void Awake()
		{
		}

		// Token: 0x060146F6 RID: 83702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F6")]
		[Address(RVA = "0xC998E0", Offset = "0xC984E0", VA = "0x180C998E0")]
		protected void Update()
		{
		}

		// Token: 0x060146F7 RID: 83703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F7")]
		[Address(RVA = "0xC99870", Offset = "0xC98470", VA = "0x180C99870")]
		protected void OnDestroy()
		{
		}

		// Token: 0x060146F8 RID: 83704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F8")]
		[Address(RVA = "0xC99B70", Offset = "0xC98770", VA = "0x180C99B70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060146F9 RID: 83705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146F9")]
		[Address(RVA = "0xC99CC0", Offset = "0xC988C0", VA = "0x180C99CC0")]
		public Act46SideSceneEffectBehaviour()
		{
		}

		// Token: 0x04018237 RID: 98871
		[Token(Token = "0x4018237")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _objects;

		// Token: 0x04018238 RID: 98872
		[Token(Token = "0x4018238")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _max;

		// Token: 0x04018239 RID: 98873
		[Token(Token = "0x4018239")]
		[FieldOffset(Offset = "0x2C")]
		private int m_curIndex;

		// Token: 0x0401823A RID: 98874
		[Token(Token = "0x401823A")]
		[FieldOffset(Offset = "0x30")]
		private Act46SideBattleManager m_manager;

		// Token: 0x0401823B RID: 98875
		[Token(Token = "0x401823B")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x0401823C RID: 98876
		[Token(Token = "0x401823C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401823D RID: 98877
		[Token(Token = "0x401823D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401823E RID: 98878
		[Token(Token = "0x401823E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401823F RID: 98879
		[Token(Token = "0x401823F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04018240 RID: 98880
		[Token(Token = "0x4018240")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
