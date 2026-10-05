using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003253 RID: 12883
	[Token(Token = "0x2003253")]
	public class Act41SideFtprgTileStart : Effect.Behaviour, ITileListener
	{
		// Token: 0x060146E7 RID: 83687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E7")]
		[Address(RVA = "0xC99020", Offset = "0xC97C20", VA = "0x180C99020", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060146E8 RID: 83688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E8")]
		[Address(RVA = "0xC98EB0", Offset = "0xC97AB0", VA = "0x180C98EB0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060146E9 RID: 83689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E9")]
		[Address(RVA = "0xC99170", Offset = "0xC97D70", VA = "0x180C99170")]
		private void Update()
		{
		}

		// Token: 0x060146EA RID: 83690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146EA")]
		[Address(RVA = "0xC98FC0", Offset = "0xC97BC0", VA = "0x180C98FC0", Slot = "10")]
		public void OnLocatedCharacterUpdate(Character character)
		{
		}

		// Token: 0x060146EB RID: 83691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146EB")]
		[Address(RVA = "0xC98CA0", Offset = "0xC978A0", VA = "0x180C98CA0", Slot = "11")]
		public void OnEntityEnter(Entity entity)
		{
		}

		// Token: 0x060146EC RID: 83692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146EC")]
		[Address(RVA = "0xC98E50", Offset = "0xC97A50", VA = "0x180C98E50", Slot = "12")]
		public void OnEntityLeave(Entity entity)
		{
		}

		// Token: 0x060146ED RID: 83693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146ED")]
		[Address(RVA = "0xC99260", Offset = "0xC97E60", VA = "0x180C99260")]
		public Act41SideFtprgTileStart()
		{
		}

		// Token: 0x060146EE RID: 83694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146EE")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060146EF RID: 83695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146EF")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018221 RID: 98849
		[Token(Token = "0x4018221")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _enemyKeyToBind;

		// Token: 0x04018222 RID: 98850
		[Token(Token = "0x4018222")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _modeToFinish;

		// Token: 0x04018223 RID: 98851
		[Token(Token = "0x4018223")]
		[FieldOffset(Offset = "0x30")]
		private Tile m_tile;

		// Token: 0x04018224 RID: 98852
		[Token(Token = "0x4018224")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<Enemy> m_bindedEnemy;

		// Token: 0x04018225 RID: 98853
		[Token(Token = "0x4018225")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018226 RID: 98854
		[Token(Token = "0x4018226")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018227 RID: 98855
		[Token(Token = "0x4018227")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018228 RID: 98856
		[Token(Token = "0x4018228")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnLocatedCharacterUpdate;

		// Token: 0x04018229 RID: 98857
		[Token(Token = "0x4018229")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEntityEnter;

		// Token: 0x0401822A RID: 98858
		[Token(Token = "0x401822A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEntityLeave;

		// Token: 0x0401822B RID: 98859
		[Token(Token = "0x401822B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
