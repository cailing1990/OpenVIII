﻿using System;


namespace OpenVIII
{
    internal sealed class Unknown4 : JsmInstruction
    {
        private IJsmExpression _arg0;

        public Unknown4(IJsmExpression arg0)
        {
            _arg0 = arg0;
        }

        public Unknown4(Int32 parameter, IStack<IJsmExpression> stack)
            : this(
                arg0: stack.Pop())
        {
        }

        public override String ToString()
        {
            return $"{nameof(Unknown4)}({nameof(_arg0)}: {_arg0})";
        }
    }
}