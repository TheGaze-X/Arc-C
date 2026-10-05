using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Lua
{
	// Token: 0x0200160C RID: 5644
	[Token(Token = "0x200160C")]
	[RequireComponent(typeof(RectTransform))]
	public class LuaLayout : MonoBehaviour
	{
		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06008010 RID: 32784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F2C")]
		public Button sysCloseButton
		{
			[Token(Token = "0x6008010")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008011")]
		[Address(RVA = "0x288BA60", Offset = "0x288A660", VA = "0x18288BA60")]
		public void InjectDefines(IList<ControllerDefine> ctrlDefines, IList<ValueFieldDefine> valueDefines)
		{
		}

		// Token: 0x06008012 RID: 32786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008012")]
		private static void _SetInjectDefineList<T>(IList<T> input, ref List<T> member)
		{
		}

		// Token: 0x06008013 RID: 32787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008013")]
		[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
		public void BindLayoutEventListener(ILuaLayoutEvent listener)
		{
		}

		// Token: 0x06008014 RID: 32788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008014")]
		[Address(RVA = "0x288BEE0", Offset = "0x288AAE0", VA = "0x18288BEE0")]
		public void TraverseCtrlDefines(Action<string, UnityEngine.Object> traverse)
		{
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008015")]
		[Address(RVA = "0x288C010", Offset = "0x288AC10", VA = "0x18288C010")]
		public void TraverseValueDefines(Action<string, string> traverse)
		{
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008016")]
		[Address(RVA = "0x288BCD0", Offset = "0x288A8D0", VA = "0x18288BCD0")]
		public void PlayTransInEffect()
		{
		}

		// Token: 0x06008017 RID: 32791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008017")]
		[Address(RVA = "0x288BD90", Offset = "0x288A990", VA = "0x18288BD90")]
		public void PlayTransOutEffect()
		{
		}

		// Token: 0x06008018 RID: 32792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008018")]
		[Address(RVA = "0x288BE50", Offset = "0x288AA50", VA = "0x18288BE50")]
		public void ShowImmediatly()
		{
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008019")]
		[Address(RVA = "0x288B9D0", Offset = "0x288A5D0", VA = "0x18288B9D0")]
		public void HideImmediatly()
		{
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600801A")]
		[Address(RVA = "0x288C140", Offset = "0x288AD40", VA = "0x18288C140")]
		private IEnumerator _TransIn()
		{
			return null;
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600801B")]
		[Address(RVA = "0x288C1C0", Offset = "0x288ADC0", VA = "0x18288C1C0")]
		private IEnumerator _TransOut()
		{
			return null;
		}

		// Token: 0x0600801C RID: 32796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600801C")]
		[Address(RVA = "0x288BB90", Offset = "0x288A790", VA = "0x18288BB90")]
		private void OnEnable()
		{
		}

		// Token: 0x0600801D RID: 32797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600801D")]
		[Address(RVA = "0x288BB40", Offset = "0x288A740", VA = "0x18288BB40")]
		private void OnDisable()
		{
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600801E")]
		[Address(RVA = "0x288BAE0", Offset = "0x288A6E0", VA = "0x18288BAE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600801F RID: 32799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600801F")]
		[Address(RVA = "0x288BC80", Offset = "0x288A880", VA = "0x18288BC80")]
		public void OnResume()
		{
		}

		// Token: 0x06008020 RID: 32800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008020")]
		[Address(RVA = "0x288BBE0", Offset = "0x288A7E0", VA = "0x18288BBE0")]
		public void OnEnter()
		{
		}

		// Token: 0x06008021 RID: 32801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008021")]
		[Address(RVA = "0x288BC30", Offset = "0x288A830", VA = "0x18288BC30")]
		public void OnExit()
		{
		}

		// Token: 0x06008022 RID: 32802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008022")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public LuaLayout()
		{
		}

		// Token: 0x0400817C RID: 33148
		[Token(Token = "0x400817C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LuaUITransEffect _transEffect;

		// Token: 0x0400817D RID: 33149
		[Token(Token = "0x400817D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _sysCloseBtn;

		// Token: 0x0400817E RID: 33150
		[Token(Token = "0x400817E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ControllerDefine[] _ctrlDefines;

		// Token: 0x0400817F RID: 33151
		[Token(Token = "0x400817F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ValueFieldDefine[] _valueDefines;

		// Token: 0x04008180 RID: 33152
		[Token(Token = "0x4008180")]
		[FieldOffset(Offset = "0x38")]
		private ILuaLayoutEvent m_event;

		// Token: 0x04008181 RID: 33153
		[Token(Token = "0x4008181")]
		[FieldOffset(Offset = "0x40")]
		private List<ControllerDefine> m_injectedCtrlDefines;

		// Token: 0x04008182 RID: 33154
		[Token(Token = "0x4008182")]
		[FieldOffset(Offset = "0x48")]
		private List<ValueFieldDefine> m_injectedValueDefines;
	}
}
