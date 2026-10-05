using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200056F RID: 1391
	[Token(Token = "0x200056F")]
	public class PrefabWidget : MonoBehaviour, IHotfixable
	{
		// Token: 0x06005B86 RID: 23430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B86")]
		public T GetWidget<T>() where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06005B87 RID: 23431 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B88 RID: 23432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CAF")]
		[Inspect]
		public GameObject widgetPrefab
		{
			[Token(Token = "0x6005B87")]
			[Address(RVA = "0x1AF8C20", Offset = "0x1AF7820", VA = "0x181AF8C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B88")]
			[Address(RVA = "0x1AF8C80", Offset = "0x1AF7880", VA = "0x181AF8C80")]
			set
			{
			}
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B89")]
		[Address(RVA = "0x1AF8A80", Offset = "0x1AF7680", VA = "0x181AF8A80")]
		private void _InitInstIfNot()
		{
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0x1AF89B0", Offset = "0x1AF75B0", VA = "0x181AF89B0")]
		private void _ClearInst()
		{
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8B")]
		[Address(RVA = "0x1AF8950", Offset = "0x1AF7550", VA = "0x181AF8950")]
		private void Awake()
		{
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8C")]
		[Address(RVA = "0x1AF8BC0", Offset = "0x1AF77C0", VA = "0x181AF8BC0")]
		public PrefabWidget()
		{
		}

		// Token: 0x0400211D RID: 8477
		[Token(Token = "0x400211D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private GameObject _widgetPrefab;

		// Token: 0x0400211E RID: 8478
		[Token(Token = "0x400211E")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_inst;

		// Token: 0x0400211F RID: 8479
		[Token(Token = "0x400211F")]
		[FieldOffset(Offset = "0x28")]
		private MonoBehaviour m_widget;

		// Token: 0x04002120 RID: 8480
		[Token(Token = "0x4002120")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetWidget;

		// Token: 0x04002121 RID: 8481
		[Token(Token = "0x4002121")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_widgetPrefab;

		// Token: 0x04002122 RID: 8482
		[Token(Token = "0x4002122")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_widgetPrefab;

		// Token: 0x04002123 RID: 8483
		[Token(Token = "0x4002123")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitInstIfNot;

		// Token: 0x04002124 RID: 8484
		[Token(Token = "0x4002124")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearInst;

		// Token: 0x04002125 RID: 8485
		[Token(Token = "0x4002125")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04002126 RID: 8486
		[Token(Token = "0x4002126")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
