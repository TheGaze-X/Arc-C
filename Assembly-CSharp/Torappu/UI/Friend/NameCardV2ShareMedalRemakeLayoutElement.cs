using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DDD RID: 19933
	[Token(Token = "0x2004DDD")]
	public class NameCardV2ShareMedalRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DCDC RID: 122076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCDC")]
		[Address(RVA = "0x1766BC0", Offset = "0x17657C0", VA = "0x181766BC0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DCDD RID: 122077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCDD")]
		[Address(RVA = "0x1766D80", Offset = "0x1765980", VA = "0x181766D80")]
		public NameCardV2ShareMedalRemakeLayoutElement()
		{
		}

		// Token: 0x04027773 RID: 161651
		[Token(Token = "0x4027773")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrossAppShareRemakeDynAssetContent _diyMedalGroup;

		// Token: 0x04027774 RID: 161652
		[Token(Token = "0x4027774")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CrossAppShareRemakeDynAssetContent _suitMedalGroup;

		// Token: 0x04027775 RID: 161653
		[Token(Token = "0x4027775")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x04027776 RID: 161654
		[Token(Token = "0x4027776")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
