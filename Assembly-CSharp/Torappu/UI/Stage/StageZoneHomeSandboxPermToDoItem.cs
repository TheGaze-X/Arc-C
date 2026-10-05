using System;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067EF RID: 26607
	[Token(Token = "0x20067EF")]
	public class StageZoneHomeSandboxPermToDoItem : StageZoneHomeToDoItemPlugin, IHotfixable
	{
		// Token: 0x06026222 RID: 156194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026222")]
		[Address(RVA = "0x213F940", Offset = "0x213E540", VA = "0x18213F940", Slot = "5")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x06026223 RID: 156195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026223")]
		[Address(RVA = "0x213F790", Offset = "0x213E390", VA = "0x18213F790", Slot = "6")]
		protected override Sprite LoadMainSprite()
		{
			return null;
		}

		// Token: 0x06026224 RID: 156196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026224")]
		[Address(RVA = "0x213FB40", Offset = "0x213E740", VA = "0x18213FB40")]
		private void _LoadSandboxPermPlugin(string topicId)
		{
		}

		// Token: 0x06026225 RID: 156197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026225")]
		[Address(RVA = "0x213FD60", Offset = "0x213E960", VA = "0x18213FD60")]
		public StageZoneHomeSandboxPermToDoItem()
		{
		}

		// Token: 0x04035B53 RID: 219987
		[Token(Token = "0x4035B53")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04035B54 RID: 219988
		[Token(Token = "0x4035B54")]
		[FieldOffset(Offset = "0x30")]
		private ZoneHomeSandboxPermTodoPluginBase m_itemView;

		// Token: 0x04035B55 RID: 219989
		[Token(Token = "0x4035B55")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedTopicId;

		// Token: 0x04035B56 RID: 219990
		[Token(Token = "0x4035B56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035B57 RID: 219991
		[Token(Token = "0x4035B57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadMainSprite;

		// Token: 0x04035B58 RID: 219992
		[Token(Token = "0x4035B58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadSandboxPermPlugin;

		// Token: 0x04035B59 RID: 219993
		[Token(Token = "0x4035B59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
