// Signature file for parser generated by fsyacc
module Parser
type token = 
  | EOF
  | PATH of (LineInfo)
  | LEQ of (LineInfo)
  | GEQ of (LineInfo)
  | LT of (LineInfo)
  | GT of (LineInfo)
  | SEMI of (LineInfo)
  | DOT of (LineInfo)
  | COMMA of (LineInfo)
  | RPAREN of (LineInfo)
  | LPAREN of (LineInfo)
  | EQUAL of (LineInfo)
  | EXISTS of (LineInfo)
  | MATCHES of (LineInfo)
  | IN of (LineInfo)
  | LET of (LineInfo)
  | ELSE of (LineInfo)
  | THEN of (LineInfo)
  | IF of (LineInfo)
  | MIN of (LineInfo)
  | MAX of (LineInfo)
  | TIMES of (LineInfo)
  | PLUS of (LineInfo)
  | OR of (LineInfo)
  | AND of (LineInfo)
  | NOT of (LineInfo)
  | INT of (LineInfo * int32)
  | ID of (LineInfo * string)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_PATH
    | TOKEN_LEQ
    | TOKEN_GEQ
    | TOKEN_LT
    | TOKEN_GT
    | TOKEN_SEMI
    | TOKEN_DOT
    | TOKEN_COMMA
    | TOKEN_RPAREN
    | TOKEN_LPAREN
    | TOKEN_EQUAL
    | TOKEN_EXISTS
    | TOKEN_MATCHES
    | TOKEN_IN
    | TOKEN_LET
    | TOKEN_ELSE
    | TOKEN_THEN
    | TOKEN_IF
    | TOKEN_MIN
    | TOKEN_MAX
    | TOKEN_TIMES
    | TOKEN_PLUS
    | TOKEN_OR
    | TOKEN_AND
    | TOKEN_NOT
    | TOKEN_INT
    | TOKEN_ID
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_exprs
    | NONTERM_expr
    | NONTERM_regex
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (Ast.Expr) 